namespace Riddle
{

    public class Check
    {
        public string SuccessText { get; set; }
        public string FailText { get; set; }
        public bool finish { get; set; }
        public bool Success { get; set; }
        public bool Fail { get; set; }

        public bool farmerThere { get; set; }
        public bool wolfThere { get; set; }
        public bool goathThere { get; set; }
        public bool cabbageThere { get; set; }

        public Check()
        {
            SuccessText = "Success!!!";
            FailText = "Fail!!!";
            finish = false;
            Success = false;
            Fail = false;
            farmerThere = false;
            wolfThere = false;
            goathThere = false;
            cabbageThere = false;
        }

        // 1) success check
        public void checkSuccess()
        {
            if (farmerThere && wolfThere && goathThere && cabbageThere)
            {
                finish = true;
                Success = true;
                //MessageBox.Show(text1);
            }
        }

        // 2)  if(wolf ate a goat or goat cabbage){...}
        public void checkFail()
        {
            if ((wolfThere && goathThere && !farmerThere)
                     || (!wolfThere && !goathThere && farmerThere)
                     || (cabbageThere && goathThere && !farmerThere)
                     || (!cabbageThere && !goathThere && farmerThere))
            {
                finish = true;
                Fail = true;
            }
        }
    }
}


