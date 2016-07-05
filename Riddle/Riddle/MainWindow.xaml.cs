using System.Windows;

namespace Riddle
{
    public delegate void checking();

    public partial class MainWindow : Window
    {
        Check checkObj = new Check();
        public checking delCheck;
        static string stringBackView = "farmer\nwolf\ngoat\ncabbage";
        public static string stringThereView = "";
        public static bool thereBack = true;
        private static string explaneText = "A farmer wants to go to the other side and take with him a wolf, a goat, and a cabbage."
            + "\nHe can take himself plus either the wolf, the goat, or the cabbage."
            + "\nIf the wolf and the goat are alone on one side, the wolf will eat the goat."
            + "\nIf the goat and the cabbage are alone on the side, the goat will eat the cabbage."
            + "\nHow can the farmer bring the wolf, the goat, and the cabbage across to the other  side?";

        public MainWindow()
        {
            InitializeComponent();
            Back.Text = stringBackView;
            There.Text = "";
            delCheck = checkObj.checkFail;
            delCheck += checkObj.checkSuccess;
            delCheck += ChangeThereBackValue;
            stringBackView = "farmer\nwolf\ngoat\ncabbage";
            stringThereView = "";
            textBlock.Text = explaneText;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (thereBack)
            {
                checkObj.wolfThere = true;
                checkObj.farmerThere = true;
                TextBackSub("farmer", "wolf");
                delCheck();
                if (checkObj.finish == true)
                {
                    BackGroundColourSuccess();
                    Message();
                    startInitialize();
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (thereBack)
            {
                checkObj.cabbageThere = true;
                checkObj.farmerThere = true;
                TextBackSub("farmer", "cabbage");
                delCheck();
                if (checkObj.finish == true)
                {
                    BackGroundColourSuccess();
                    Message();
                    startInitialize();
                }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (thereBack)
            {
                checkObj.goathThere = true;
                checkObj.farmerThere = true;
                TextBackSub("farmer", "goat");
                delCheck();
                if (checkObj.finish == true)
                {
                    BackGroundColourSuccess();
                    Message();
                    startInitialize();
                }
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (thereBack)
            {
                checkObj.farmerThere = true;
                TextBackSub("farmer");
                delCheck();
                if (checkObj.finish == true)
                {
                    BackGroundColourSuccess();
                    Message();
                    startInitialize();
                }
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (!thereBack)
            {
                checkObj.wolfThere = false;
                checkObj.farmerThere = false;
                TextThereSub("farmer", "wolf");
                delCheck();
                if (checkObj.finish == true)
                {
                    BackGroundColourSuccess();
                    Message();
                    startInitialize();
                }
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (!thereBack)
            {
                checkObj.cabbageThere = false;
                checkObj.farmerThere = false;
                TextThereSub("farmer", "cabbage");
                delCheck();
                if (checkObj.finish == true)
                {
                    BackGroundColourSuccess();
                    Message();
                    startInitialize();
                }
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (!thereBack)
            {
                checkObj.goathThere = false;
                checkObj.farmerThere = false;
                TextThereSub("farmer", "goat");
                delCheck();
                if (checkObj.finish == true)
                {
                    BackGroundColourSuccess();
                    Message();
                    startInitialize();
                }
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (!thereBack)
            {
                checkObj.farmerThere = false;
                TextThereSub("farmer");
                delCheck();
                if (checkObj.finish == true)
                {
                    BackGroundColourSuccess();
                    Message();
                    startInitialize();
                }
            }
        }

        // Show new values for the TextBox Back and There
        public void TextBackSub(params string[] substr)
        {
            foreach (string str in substr)
            {
                int n = stringBackView.IndexOf(str);
                if (n >= 0)
                {
                    stringBackView = stringBackView.Remove(n, str.Length);
                    stringThereView += "\n" + str;
                }
            }
            Back.Text = stringBackView;
            There.Text = stringThereView;
        }

        // Show new values for the TextBox Back and There
        public void TextThereSub(params string[] substr)
        {
            foreach (string str in substr)
            {
                int n = stringThereView.IndexOf(str);
                if (n >= 0)
                {
                    stringThereView = stringThereView.Remove(n, str.Length);
                    stringBackView += "\n" + str;
                }
            }
            Back.Text = stringBackView;
            There.Text = stringThereView;
        }

        // Reset values and setting the starting position to retry
        void startInitialize()
        {
            stringBackView = "farmer\nwolf\ngoat\ncabbage";
            stringThereView = "";
            Back.Text = stringBackView;
            There.Text = stringThereView;
            checkObj.finish = false;
            There.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White);
            Back.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White);
            checkObj.farmerThere = false;
            checkObj.wolfThere = false;
            checkObj.goathThere = false;
            checkObj.cabbageThere = false;
            checkObj.Success = false;
            checkObj.Fail = false;
            thereBack = true;
        }

        void Message()
        {
            if (checkObj.Success == true) MessageBox.Show(checkObj.SuccessText);
            if (checkObj.Fail == true) MessageBox.Show(checkObj.FailText);
        }

        void BackGroundColourSuccess()
        {
            if (checkObj.Success == true)
            {
                There.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LightGreen);
                Back.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LightGreen);
            }
            if (checkObj.Fail == true)
            {
                There.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LightPink);
                Back.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LightPink);
            }
        }

        void ChangeThereBackValue()
        {
            if (thereBack) thereBack = false;
            else thereBack = true;
        }
    }
}


