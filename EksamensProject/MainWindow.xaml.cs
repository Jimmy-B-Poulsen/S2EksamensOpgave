using EksamensProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace EksamensProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Shows/hides Player information in xaml
        private void btnPlayers_Click(object sender, RoutedEventArgs e)
        {
            if (grdPlayers.Visibility == Visibility.Visible)
            {
                grdPlayers.Visibility = Visibility.Hidden;
            }
            else
            {
                grdPlayers.Visibility = Visibility.Visible;
                grdTurnaments.Visibility = Visibility.Hidden;
                grdSponsors.Visibility = Visibility.Hidden;
                grdWorkers.Visibility = Visibility.Hidden;
            }
        }

        //Shows/hides turnament information in xaml
        private void btnTurnament_Click(object sender, RoutedEventArgs e)
        {
            if (grdTurnaments.Visibility == Visibility.Visible)
            {
                grdTurnaments.Visibility = Visibility.Hidden;
            }
            else
            {
                grdPlayers.Visibility = Visibility.Hidden;
                grdTurnaments.Visibility = Visibility.Visible;
                grdSponsors.Visibility = Visibility.Hidden;
                grdWorkers.Visibility = Visibility.Hidden;
            }
        }

        //Shows/hides workers information in xaml
        private void btnWokers_Click(object sender, RoutedEventArgs e)
        {
            if (grdWorkers.Visibility == Visibility.Visible)
            {
                grdWorkers.Visibility = Visibility.Hidden;
            }
            else
            {
                grdPlayers.Visibility = Visibility.Hidden;
                grdTurnaments.Visibility = Visibility.Hidden;
                grdSponsors.Visibility = Visibility.Hidden;
                grdWorkers.Visibility = Visibility.Visible;
            }
        }

        //Shows/hides sponsors information in xaml
        private void btnSponsors_Click(object sender, RoutedEventArgs e)
        {
            if (grdSponsors.Visibility == Visibility.Visible)
            {
                grdSponsors.Visibility = Visibility.Hidden;
            }
            else
            {
                grdPlayers.Visibility = Visibility.Hidden;
                grdTurnaments.Visibility = Visibility.Hidden;
                grdSponsors.Visibility = Visibility.Visible;
                grdWorkers.Visibility = Visibility.Hidden;
            }
        }

        ////Shows/hides add player in xaml
        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (txtblkPlayerName.Visibility == Visibility.Visible)
            {
                txtblkPlayerName.Visibility = Visibility.Hidden;
                txtbxPlayerName.Visibility = Visibility.Hidden;
                txtblkPlayerSummonerName.Visibility = Visibility.Hidden;
                txtbxPlayerSummonerName.Visibility = Visibility.Hidden;
                txtblkPlayerRank.Visibility = Visibility.Hidden;
                txtbxPlayerRank.Visibility = Visibility.Hidden;
                txtblkPlayerPhone.Visibility = Visibility.Hidden;
                txtbxPlayerPhone.Visibility = Visibility.Hidden;
                txtblkPlayerTurnamentType.Visibility = Visibility.Hidden;
                txtbxPlayerTurnamentType.Visibility = Visibility.Hidden;
                btnPlayerInfoAccept.Visibility = Visibility.Hidden;
            }
            else
            {
                txtblkPlayerName.Visibility = Visibility.Visible;
                txtbxPlayerName.Visibility = Visibility.Visible;
                txtblkPlayerSummonerName.Visibility = Visibility.Visible;
                txtbxPlayerSummonerName.Visibility = Visibility.Visible;
                txtblkPlayerRank.Visibility = Visibility.Visible;
                txtbxPlayerRank.Visibility = Visibility.Visible;
                txtblkPlayerPhone.Visibility = Visibility.Visible;
                txtbxPlayerPhone.Visibility = Visibility.Visible;
                txtblkPlayerTurnamentType.Visibility = Visibility.Visible;
                txtbxPlayerTurnamentType.Visibility = Visibility.Visible;
                btnPlayerInfoAccept.Visibility = Visibility.Visible;
            }
        }

        //Creates object to be sent to biz layer on button click
        private void btnPlayerInfoAccept_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player(txtbxPlayerName.Text, txtbxPlayerSummonerName.Text, txtbxPlayerRank.Text, txtbxPlayerPhone.Text, txtbxPlayerTurnamentType.Text);
            Biz biz = new Biz();
            biz.PlayerInfoTransfer(player);
            
        }


        private void btnAddTurnament_Click(object sender, RoutedEventArgs e)
        {
            if (btnTurnamentInfoAccept.Visibility == Visibility.Visible)
            {
                txtblkTurnamentName.Visibility = Visibility.Hidden;
                txtbxTurnamentName.Visibility = Visibility.Hidden;
                txtblkPlayerID.Visibility = Visibility.Hidden;
                txtbxPlayerID.Visibility = Visibility.Hidden;
                txtblkPlayerNameForTurnament.Visibility = Visibility.Hidden;
                txtbxPlayerNameForTurnament.Visibility = Visibility.Hidden;
                txtblkPlayerPhoneForTurnament.Visibility = Visibility.Hidden;
                txtbxPlayerPhoneForTurnament.Visibility = Visibility.Hidden;
                txtblkJudgeID.Visibility = Visibility.Hidden;
                txtbxJudgeID.Visibility = Visibility.Hidden;
                txtblkJudgeNameForTurnament.Visibility = Visibility.Hidden;
                txtbxJudgeNameForTurnament.Visibility = Visibility.Hidden;
                txtblkJudgePhoneForTurnament.Visibility = Visibility.Hidden;
                txtbxJudgePhoneForTurnament.Visibility = Visibility.Hidden;
                txtblkJudgeLevelForTurnament.Visibility = Visibility.Hidden;
                txtbxJudgeLevelForTurnament.Visibility = Visibility.Hidden;

                btnTurnamentInfoAccept.Visibility = Visibility.Hidden;
            }
            else
            {
                txtblkTurnamentName.Visibility = Visibility.Visible;
                txtbxTurnamentName.Visibility = Visibility.Visible;
                txtblkPlayerID.Visibility = Visibility.Visible;
                txtbxPlayerID.Visibility = Visibility.Visible;
                txtblkPlayerNameForTurnament.Visibility = Visibility.Visible;
                txtbxPlayerNameForTurnament.Visibility = Visibility.Visible;
                txtblkPlayerPhoneForTurnament.Visibility = Visibility.Visible;
                txtbxPlayerPhoneForTurnament.Visibility = Visibility.Visible;
                txtblkJudgeID.Visibility = Visibility.Visible;
                txtbxJudgeID.Visibility = Visibility.Visible;
                txtblkJudgeNameForTurnament.Visibility = Visibility.Visible;
                txtbxJudgeNameForTurnament.Visibility = Visibility.Visible;
                txtblkJudgePhoneForTurnament.Visibility = Visibility.Visible;
                txtbxJudgePhoneForTurnament.Visibility = Visibility.Visible;
                txtblkJudgeLevelForTurnament.Visibility = Visibility.Visible;
                txtbxJudgeLevelForTurnament.Visibility = Visibility.Visible;

                btnTurnamentInfoAccept.Visibility = Visibility.Visible;
            }
        }

        private void btnTurnamentInfoAccept_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnAddWorker_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnAddSponsor_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnListUpdate_Click(object sender, RoutedEventArgs e)
        {
            Biz biz = new Biz();
            biz.UpdatePlayerBox();
        }
    }
}
