using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ded
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            Window1 window1 = (Window1)GetWindow(this);
            window1.MinHeight = 380;
            window1.MinWidth = 460;

            RowDefinition rowDefinitionMain0 = new RowDefinition();
            RowDefinition rowDefinitionMain2 = new RowDefinition();
            rowDefinitionMain0.Height = new GridLength(50, GridUnitType.Pixel);
            rowDefinitionMain2.Height = new GridLength(25, GridUnitType.Pixel);
            gridMain.RowDefinitions.Add(rowDefinitionMain0);
            gridMain.RowDefinitions.Add(new RowDefinition());
            gridMain.RowDefinitions.Add(rowDefinitionMain2);


            Border border = new Border();
            border.BorderThickness = new Thickness(0, 0, 0, 1);
            border.BorderBrush = (Brush)(new BrushConverter().ConvertFrom("#6995c2"));
            Grid.SetRow(border, 0);
            gridMain.Children.Add(border);

            Grid head = new Grid();
            Grid.SetRow(head, 0);
            gridMain.Children.Add(head);

            DockPanel dockPanel = new DockPanel();
            dockPanel.HorizontalAlignment = HorizontalAlignment.Left;
            head.Children.Add(dockPanel);

            Image logo = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("logo.jpg", UriKind.Relative);
            bi3.EndInit();
            logo.Source = bi3;
            logo.Height = head.Height;
            dockPanel.Children.Add(logo);

            Label nba = new Label();
            nba.Content = "NBA Management System";
            nba.VerticalAlignment = VerticalAlignment.Center;
            dockPanel.Children.Add(nba);

            Label admin = new Label();
            admin.Content = "Admin Login";
            admin.HorizontalAlignment = HorizontalAlignment.Center;
            admin.VerticalAlignment = VerticalAlignment.Center;
            head.Children.Add(admin);

            Button back = new Button();
            back.Content = "Back";
            back.HorizontalAlignment = HorizontalAlignment.Right;
            back.Height = 20;
            back.Width = 50;
            back.Margin = new Thickness(10);
            head.Children.Add(back);


            Grid body = new Grid();
            Grid.SetRow(body, 1);
            body.Height = 250;
            body.Width = 400;
            gridMain.Children.Add(body);

            for (int i = 0; i < 5; i++)
                body.RowDefinitions.Add(new RowDefinition());
            for (int j = 0; j < 3; j++)
                body.ColumnDefinitions.Add(new ColumnDefinition());

            Label users = new Label();
            users.Content = "Users can login into the system  using their jobnumber and password.";
            Grid.SetRow(users, 0);
            Grid.SetColumn(users, 0);
            Grid.SetColumnSpan(users, 3);
            users.HorizontalAlignment = HorizontalAlignment.Center;
            users.VerticalAlignment = VerticalAlignment.Center;
            body.Children.Add(users);

            Label jub = new Label();
            jub.Content = "Jobnumber:";
            Grid.SetRow(jub, 1);
            Grid.SetColumn(jub, 0);
            jub.VerticalAlignment = VerticalAlignment.Center;
            jub.HorizontalAlignment = HorizontalAlignment.Right;
            body.Children.Add(jub);

            TextBox jubT = new TextBox();
            Grid.SetRow(jubT, 1);
            Grid.SetColumn(jubT, 1);
            Grid.SetColumnSpan(jubT, 2);
            jubT.VerticalAlignment = VerticalAlignment.Center;
            jubT.BorderThickness = new Thickness(1);
            jubT.BorderBrush = Brushes.LightGray;
            jubT.Height = 30;
            jubT.Width = 240;
            body.Children.Add(jubT);

            Label pas = new Label();
            pas.Content = "Password:";
            Grid.SetRow(pas, 2);
            Grid.SetColumn(pas, 0);
            pas.VerticalAlignment = VerticalAlignment.Center;
            pas.HorizontalAlignment = HorizontalAlignment.Right;
            body.Children.Add(pas);

            TextBox pasT = new TextBox();
            Grid.SetRow(pasT, 2);
            Grid.SetColumn(pasT, 1);
            Grid.SetColumnSpan(pasT, 2);
            pasT.VerticalAlignment = VerticalAlignment.Center;
            pasT.BorderThickness = new Thickness(1);
            pasT.BorderBrush = Brushes.LightGray;
            pasT.Height = 30;
            pasT.Width = 240;
            body.Children.Add(pasT);

            CheckBox checkBox = new CheckBox();
            checkBox.Content = "Remember me";
            Grid.SetRow(checkBox, 3);
            Grid.SetColumn(checkBox, 1);
            checkBox.VerticalAlignment = VerticalAlignment.Center;

            Button log = new Button();
            log.Content = "Login";
            Grid.SetRow(log, 4);
            Grid.SetColumn(log, 1);
            log.VerticalAlignment = VerticalAlignment.Center;
            log.HorizontalAlignment = HorizontalAlignment.Left;
            log.Width = 70;
            log.Height = 30;
            log.Margin = new Thickness(10, 0, 0, 0);
            body.Children.Add(log);

            Button canecl = new Button();
            canecl.Content = "Cancel";
            Grid.SetRow(canecl, 4);
            Grid.SetColumn(canecl, 2);
            canecl.VerticalAlignment = VerticalAlignment.Center;
            canecl.HorizontalAlignment = HorizontalAlignment.Center;
            canecl.Width = 70;
            canecl.Height = 30;
            body.Children.Add(canecl);

            Label textBlock = new Label();
            textBlock.Content = "The current season is 2016-2017, and the NBA already has a history of 71 years.";
            Grid.SetRow(textBlock, 2);
            textBlock.HorizontalContentAlignment = HorizontalAlignment.Center;
            textBlock.Background = (Brush)(new BrushConverter().ConvertFrom("#6995c2"));
            textBlock.Foreground = Brushes.White;
            gridMain.Children.Add(textBlock);
        }
    }
}
