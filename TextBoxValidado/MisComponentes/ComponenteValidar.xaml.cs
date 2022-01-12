using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextBoxValidado.MisComponentes
{
    /// <summary>
    /// Interaction logic for ComponenteValidar.xaml
    /// </summary>
    public partial class ComponenteValidar : UserControl
    {
        public string tipoValidacion { get; set; }
        public ComponenteValidar()
        {
            InitializeComponent();
        }

        // Para comprobar la validacion es necesario hacer doble click dentro del TextBox
        //https://stackoverflow.com/questions/3334388/getting-the-text-value-from-a-textbox
        //https://social.msdn.microsoft.com/Forums/en-US/2cdabac1-c439-4191-b919-8fbfff97a2db/aporte-usando-expresiones-regulares-para-validar-datoscorreo-electrnicosolo-letrassolo?forum=vcses
        private void TxtBoxCP_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //TextBox textboxCP = (TextBox)sender;
            //string datosTextBox = textboxCP.Text;

            switch (tipoValidacion)
            {
                case "cp":
                    Regex valor = new Regex(@"^([0-5]{2}|[0-9][0-9]|[0-9][0-9])[0-9]{3}$");

                    if (valor.IsMatch(TxtBoxCP.Text))
                    {
                        MessageBox.Show("El codigo postal SI es valido", "Confirmacion");
                    }
                    else
                    {
                        MessageBox.Show("El codigo postal NO es valido", "Error");
                        TxtBoxCP.Focus();
                    }
                    break;
                
                case "email":
                    Regex email = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

                    if (email.IsMatch(TxtBoxCP.Text))
                    {
                        MessageBox.Show("El email SI es valido", "Confirmacion");
                    }
                    else
                    {
                        MessageBox.Show("El email NO es valido", "Error");
                        TxtBoxCP.Focus();
                    }
                    break;
            }
        }
    }
}
