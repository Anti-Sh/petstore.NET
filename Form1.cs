namespace petstore.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel[] panels = { queryPanel1, queryPanel2, queryPanel3 };
            foreach (var pan in panels)
                pan.Location = new Point(12, 133);

            hideAll();
            selectQuery.SelectedIndex = 0;
            resultHeader.Visible = false;
        }
        private void hideAll()
        {
            Panel[] panels = { queryPanel1, queryPanel2, queryPanel3 };
            foreach (var pan in panels)
                pan.Visible = false;
        }
        
        private void queryDo_Click(object sender, EventArgs e)
        {
            DB.OpenConnection();
            string query = "";
            string date = "";
            switch (selectQuery.SelectedIndex)
            {
                case 0:
                    result1.Rows.Clear();
                    date = DateTime.Now.AddHours(-24).ToString("yyyy-MM-dd HH:mm:ss");
                    query = String.Format("SELECT `o`.`id`, `u`.`email`, `o`.`datetime`, `o`.`status` FROM `orders` `o` INNER JOIN `users` `u` ON `o`.`user_id`=`u`.`id` WHERE `o`.`datetime`>'{0}';", date);
                    var resultDB1 = DB.ExecuteQuery(query, 4);
                    try
                    {
                        foreach(var item in resultDB1)
                            result1.Rows.Add(item);
                        queryPanel1.Visible = true;
                        resultHeader.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Ничего не найдено!", "Ошибка");
                    }
                    break;
                case 1:
                    result2.Rows.Clear();
                    date = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd HH:mm:ss");
                    query = String.Format("SELECT `c`.`id`, `c`.`name`, `c`.`cost`, (SELECT COUNT(*) FROM `orders_products` `o` INNER JOIN `orders` `ord` ON `o`.`order_id`=`ord`.`id` WHERE `o`.`product_id`=`c`.`id` AND `ord`.`datetime`>'{0}') AS `count` FROM `catalog` `c` ORDER BY `count` DESC LIMIT 1;", date);
                    var resultDB2 = DB.ExecuteQuery(query, 4);
                    try
                    {
                        result2.Rows.Add(resultDB2[0]);
                        queryPanel2.Visible = true;
                        resultHeader.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Ничего не найдено!", "Ошибка");
                    }

                    break;
                case 2:
                    date = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd HH:mm:ss");
                    query = String.Format("SELECT SUM(`c`.`cost` * `o`.`count`) FROM `orders_products` `o` INNER JOIN `orders` `ord` ON `o`.`order_id`=`ord`.`id` INNER JOIN `catalog` `c` ON `c`.`id`=`o`.`product_id` WHERE `ord`.`datetime`>'{0}';", date);
                    var resultDB3 = DB.ExecuteQuery(query);

                    result3.Text = resultDB3 != "" ? resultDB3 : "0";
                    queryPanel3.Visible = true;
                    resultHeader.Visible = true;
                    break;
            }
            DB.CloseConnection();
        }

        private void selectQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideAll();
            resultHeader.Visible = false;
        }
    }
}