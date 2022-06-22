using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SQL_Tutorial.Views
{
    /// <summary>
    /// Interaktionslogik für SqlRueckgabe.xaml
    /// </summary>
    public partial class SqlRueckgabe : Window
    {
        public int Columns;
        public int Rows;

        public SqlRueckgabe(List<List<string>> sqlOutput)
        {
            InitializeComponent();

            Columns = sqlOutput.First().Count();
            Rows = sqlOutput.Count();

            // Create the Grid
            var displayGrid = new Grid();
            displayGrid.HorizontalAlignment = HorizontalAlignment.Left;
            displayGrid.VerticalAlignment = VerticalAlignment.Top;
            displayGrid.Background = Brushes.DarkGray;

            //incase we want a border
            //displayGrid.ShowGridLines = true;

            //add colums to the grid
            for (int x = 0; x < Columns; x++)
            {
                ColumnDefinition temp = new ColumnDefinition();
                displayGrid.ColumnDefinitions.Add(temp);
            }

            //add rows to the grid
            for (int x = 0; x < Rows + 1; x++)
            {
                RowDefinition temp = new RowDefinition();
                displayGrid.RowDefinitions.Add(temp);
            }

            //reset counters
            var colCounter = 0;
            var rowCounter = 0;

            sqlOutput.ForEach(eachRow =>
            {
                eachRow.ForEach(eachString =>
                {
                    //textblock for the text inside the cells
                    TextBlock tempTextBlock = new TextBlock();
                    tempTextBlock.Margin = new Thickness(8);
                    tempTextBlock.Text = eachString;

                    //create a rectangle inside a cell, and color is light blue, or light green
                    Rectangle r = new Rectangle();
                    _ = (rowCounter) % 2 == 0 ? r.Fill = Brushes.LightBlue : r.Fill = Brushes.Honeydew;
                    Grid.SetRow(r, rowCounter);
                    Grid.SetColumn(r, colCounter);
                    displayGrid.Children.Add(r);

                    if (rowCounter == 0)
                    {
                        //header cell
                        tempTextBlock.FontSize = 18;
                        tempTextBlock.FontWeight = FontWeights.Bold;
                    }
                    else
                    {
                        //all other cells
                        tempTextBlock.FontSize = 15;
                        tempTextBlock.FontWeight = FontWeights.Regular;
                    }

                    //tell the grid where the textblock is, and then add it to our grid
                    Grid.SetRow(tempTextBlock, rowCounter);
                    Grid.SetColumn(tempTextBlock, colCounter);
                    displayGrid.Children.Add(tempTextBlock);

                    colCounter++;
                });
                rowCounter++;
                colCounter = 0;
            });

            //a scrollviewer so the grid has a scrollbar
            var scrollViewer = new ScrollViewer();
            scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            scrollViewer.Content = displayGrid;
            
            Content = scrollViewer;
        }
    }
}
