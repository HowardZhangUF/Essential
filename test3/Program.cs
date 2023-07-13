using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        public class MyButton
        {
            public event EventHandler Click;

            public void OnClick()
            {
                Click?.Invoke(this, EventArgs.Empty);
            }
        }

        public class MyForm
        {
            private MyButton _button = new MyButton();

            public MyForm()
            {
                _button.Click += Button_Click;
            }

            private void Button_Click(object sender, EventArgs e)
            {
                // handle button click event
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
