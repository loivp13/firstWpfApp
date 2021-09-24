using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();
            //create the connectionString;
            string connectionString = ConfigurationManager.ConnectionStrings["WpfApp1.Properties.Settings.LoivpMSSQLDB_1ConnectionString"].ConnectionString;
            //create a sqlConnection;
            sqlConnection = new SqlConnection(connectionString);

            //display from database
            ShowZoos();
            ShowAllAnimals();
        }

        private void ShowZoos()
        {
            try
            {
                //create query
                string query = "select * from Zoo";
                //create an adapter with query
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                //store data within an object
                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();

                    sqlDataAdapter.Fill(zooTable);

                    //which information of the table in datatable should be shown in our ListBox?
                    listZoos.DisplayMemberPath = "Location";
                    //which value should be delivered, when an item from our listbox is selected?
                    listZoos.SelectedValuePath = "Id";
                    //reference to the data the list should populate
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ShowAssociatedAnimals()
        {
            try
            {
                //create query
                string query = "select * from Animal a inner join ZooAnimal za on a.Id = za.AnimalId where za.ZooId = @ZooId";

                //using sql command to add variables
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                //create an adapter with query
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //store data within an object
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@Zooid", listZoos.SelectedValue);

                    DataTable animalTable = new DataTable();

                    sqlDataAdapter.Fill(animalTable);

                    //which information of the table in datatable should be shown in our ListBox?
                    listAssociatedAnimals.DisplayMemberPath = "Name";

                    //which value should be delivered, when an item from our listbox is selected?
                    listAssociatedAnimals.SelectedValuePath = "Id";

                    //reference to the data the list should populate
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        } 
        
        private void ShowAllAnimals()
        {
            try
            {
                //create query
                string query = "select * from Animal";

             
                //create an adapter with query
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                //store data within an object
                using (sqlDataAdapter)
                {

                    DataTable allAnimalTable = new DataTable();

                    sqlDataAdapter.Fill(allAnimalTable);

                    //which information of the table in datatable should be shown in our ListBox?
                    listAllAnimals.DisplayMemberPath = "Name";

                    //which value should be delivered, when an item from our listbox is selected?
                    listAllAnimals.SelectedValuePath = "Id";

                    //reference to the data the list should populate
                    listAllAnimals.ItemsSource = allAnimalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listZoos.SelectedItem != null)
            {

            ShowAssociatedAnimals();
            }
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from zoo where id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
            
      


        }
        
        private void RemoveAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from zoo where id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
            
      


        }
        
        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from zoo where id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
            
      


        } 
        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from zoo where id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
            
      


        }

    }
}