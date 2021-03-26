using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VehicleDescriptionGenerator
{
    public partial class A6 : Form
    {
        Thread th;
        //################################# PACKAGES ###################################
        string coldWeatherPackageOption = "";
        string sportPackageOption19 = "";
        string blackOpticPackageOption19 = "";
        string blackOpticPackageOption20 = "";
        string wheelPackageOption20 = "";
        string warmWeatherPackageOption = "";
        string driverAssistancePackageOption = "";
        string a630TCompetitionPackageOption = "";
        string comfortSeatingPackageOption = "";
        //################################# OPTIONS ######################################
        string blindSpotMonitoringOption = "";
        string laneDepartureMonitoringOption = "";
        string bluetoothPhoneConnectivityOption = "";
        string siriusHdRadioOption = "";
        string voiceControlSystemOption = "";
        string navigationSystemOption = "";
        string parkingAssistWBackupCameraAndParkingSensorsOption = "";
        string rearviewCameraWifiOnlineServicesWAudiConnectOption = "";
        string garageDoorOpenerKeylessEntryOption = "";
        string collisionPreventionWAutomaticBreakingSystemOption = "";
        string headUpDisplayWNavigationAndAssistanceSystemsInformationOption = "";
        string audiPreSenseRearOption = "";
        string hillDescentControlOption = "";
        string automaticHeadlightsOption = "";
        string threeZoneAutomaticClimateControlOption = "";
        string heatedSeatsOption = "";
        string heatedSteeringWheelOption = "";
        string panoramicSunroofOption = "";
        string adaptiveCruiseControlWithAutomaticStopNGoFunctionOption = "";
        string audiVirtualCockpitOption = "";
        string ventilatedFrontSeatsOption = "";
        string sportsSeatsOption = "";
        string bangNOlufsenHdPremiumSoundSystemOption = "";
        string bossHdPremiumSoundSystemOption = "";

        string audiCertifiedOption = "";
        string fiveDaysMoneyBackOption = "";
        string equipedWithEquippedWOptions = "\nEquipped with: ";
        string callToday = " Call today to schedule a no obligation test drive!\n";
        string andMuchMore = " and so much more!";
        string template = "\nThis Herb Chambers Certified Pre-owned Vehicle has received a rigorous " +
            "multi-point inspection by our factory trained technicians, and then professionally detailed. " +
            "Receipt and complete pre-owned portfolio will be provided when you visit for your test drive.\n";
        string text = "";

        public A6()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openHomeForm(object obj)
        {
            Application.Run(new Page1());
        }  
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void goToA4Package_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        //cold weather package
        private void ldWeatherPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (ldWeatherPackage.Checked == true)
                coldWeatherPackageOption = "*Cold Weather Package\n";
            else
                coldWeatherPackageOption = "";
        }
        private void sportPackage19_CheckedChanged(object sender, EventArgs e)
        {
            if (sportPackage19.Checked == true)
                sportPackageOption19 = "*19\"Sport Package\n";
            else
                sportPackageOption19 = "";
        }
        private void blackOpticPackage19_CheckedChanged(object sender, EventArgs e)
        {
            if (blackOpticPackage19.Checked == true)
                blackOpticPackageOption19 = "*19\" Black Optic Package\n";
            else
                blackOpticPackageOption19 = "";
        }
        //20"
        private void blackOpticPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (blackOpticPackage.Checked == true)
                blackOpticPackageOption20 = "*20\" Black Optic Package\n";
            else
                blackOpticPackageOption20 = "";
        }
        private void warmWeatherPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (warmWeatherPackage.Checked == true)
                warmWeatherPackageOption = "*Warm Weather Package\n";
            else
                warmWeatherPackageOption = "";
        }
        private void wheelPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (wheelPackage.Checked == true)
                wheelPackageOption20 = "*20\" Wheel Package\n";
            else
                wheelPackageOption20 = "";
        }
        private void driverAssistancePackage_CheckedChanged(object sender, EventArgs e)
        {
            if (driverAssistancePackage.Checked == true)
                driverAssistancePackageOption = "*Driver Assistance Package\n";
            else
                driverAssistancePackageOption = "";
        }

        private void competitionPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (competitionPackage.Checked == true)
                a630TCompetitionPackageOption = "*A6 3.0T Competition Package\n";
            else
                a630TCompetitionPackageOption = "";
        }
        private void comfortSeatinPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (comfortSeatinPackage.Checked == true)
                comfortSeatingPackageOption = "*Comfort Seating Package\n";
            else
                comfortSeatingPackageOption = "";
        }
        private void headUpDisplayWNavigationAndAssistanceSystemsInformation_CheckedChanged(object sender, EventArgs e)
        {
            if (headUpDisplayWNavigationAndAssistanceSystemsInformation.Checked == true)
            {
                headUpDisplayWNavigationAndAssistanceSystemsInformationOption =
                " Head-up Display with Navigation and Assistance Systems Information,";
            }
            else
                headUpDisplayWNavigationAndAssistanceSystemsInformationOption = "";
        }
        private void siriusHDRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (siriusHDRadio.Checked == true)
                siriusHdRadioOption = " SIRIUS HD Radio,";
            else
                siriusHdRadioOption = "";
        }
        private void navigationSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (navigationSystem.Checked == true)
                navigationSystemOption = " Navigation System,";
            else
                navigationSystemOption = "";
        }
        private void audiPreSenseRear_CheckedChanged(object sender, EventArgs e)
        {
            if (audiPreSenseRear.Checked == true)
                audiPreSenseRearOption = " Audi Pre-Sense Rear,";
            else
                audiPreSenseRearOption = "";
        }
        private void blindSpotMonitoring_CheckedChanged(object sender, EventArgs e)
        {
            if (blindSpotMonitoring.Checked == true)
                blindSpotMonitoringOption = "Blind Spot Monitoring, ";
            else
                blindSpotMonitoringOption = "";
        }
        private void heatedSeats_CheckedChanged(object sender, EventArgs e)
        {
            if (heatedSeats.Checked == true)
                heatedSeatsOption = " Heated Seats,";
            else
                heatedSeatsOption = "";
        }
        private void bangAndOlufsenHDPremiumSoundSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (bangAndOlufsenHDPremiumSoundSystem.Checked == true)
                bangNOlufsenHdPremiumSoundSystemOption = " Bang & Olufsen HD Premium Sound System,";
            else
                bangNOlufsenHdPremiumSoundSystemOption = "";
        }
        private void bLUETOOTHPhoneConnectivity_CheckedChanged(object sender, EventArgs e)
        {
            if (bLUETOOTHPhoneConnectivity.Checked == true)
                bluetoothPhoneConnectivityOption = " BLUETOOTH Phone Connectivity,";
            else
                bluetoothPhoneConnectivityOption = "";
        }
        private void garageDoorOpenerKeylessEntry_CheckedChanged(object sender, EventArgs e)
        {
            if (garageDoorOpenerKeylessEntry.Checked == true)
                garageDoorOpenerKeylessEntryOption = " Garage Door Opener, Keyless Entry,";
            else
                garageDoorOpenerKeylessEntryOption = "";
        }
        private void laneDepartureMonitoring_CheckedChanged(object sender, EventArgs e)
        {
            if (laneDepartureMonitoring.Checked == true)
                laneDepartureMonitoringOption = " Lane Departure Monitoring,";
            else
                laneDepartureMonitoringOption = "";
        }
        private void automaticHeadlights_CheckedChanged(object sender, EventArgs e)
        {
            if (automaticHeadlights.Checked == true)
                automaticHeadlightsOption = " Automatic Headlights,";
            else
                automaticHeadlightsOption = "";
        }
        private void heatedSteeringWheel_CheckedChanged(object sender, EventArgs e)
        {
            if (heatedSteeringWheel.Checked == true)
                heatedSteeringWheelOption = " Heated Steering Wheel,";
            else
                heatedSteeringWheelOption = "";
        }
        private void threeZoneAutomaticClimateControl_CheckedChanged(object sender, EventArgs e)
        {
            if (threeZoneAutomaticClimateControl.Checked == true)
                threeZoneAutomaticClimateControlOption = " Three-zone Automatic Climate Control,";
            else
                threeZoneAutomaticClimateControlOption = "";
        }
        private void collisionPreventionWAutomaticBreakingSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (collisionPreventionWAutomaticBreakingSystem.Checked == true)
            {
                collisionPreventionWAutomaticBreakingSystemOption =
                " Collision Prevention with Automatic Breaking System,";
            }
            else
                collisionPreventionWAutomaticBreakingSystemOption = "";
        }
        private void bossHDPremiumSoundSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (bossHDPremiumSoundSystem.Checked == true)
                bossHdPremiumSoundSystemOption = " Boss HD Premium Sound System,";
            else
                bossHdPremiumSoundSystemOption = "";
        }
        private void parkingAssistWBackupCameraAndParkingSensors_CheckedChanged(object sender, EventArgs e)
        {
            if (parkingAssistWBackupCameraAndParkingSensors.Checked == true)
            {
                parkingAssistWBackupCameraAndParkingSensorsOption =
                " Parking Assist with Backup Camera and Parking Sensors,";
            }
            else
                parkingAssistWBackupCameraAndParkingSensorsOption = "";
        }
        private void RearviewCameraWIFIOnlineServicesWAudiConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (RearviewCameraWIFIOnlineServicesWAudiConnect.Checked == true)
            {
                rearviewCameraWifiOnlineServicesWAudiConnectOption =
                " Rearview Camera, WIFI & Online Services with Audi Connect,";
            }
            else
                rearviewCameraWifiOnlineServicesWAudiConnectOption = "";
        }
        private void adaptiveCruiseControlWithAutomaticStopGoFunction_CheckedChanged(object sender, EventArgs e)
        {
            if (adaptiveCruiseControlWithAutomaticStopGoFunction.Checked == true)
            {
                adaptiveCruiseControlWithAutomaticStopNGoFunctionOption =
                    " Adaptive Cruise Control (with Automatic Stop & Go Function),";
            }
            else
                adaptiveCruiseControlWithAutomaticStopNGoFunctionOption = "";
        }
        private void panoramicSunroof_CheckedChanged(object sender, EventArgs e)
        {
            if (panoramicSunroof.Checked == true)
                panoramicSunroofOption = " Panoramic Sunroof,";
            else
                panoramicSunroofOption = "";
        }
        private void sportsSeats_CheckedChanged(object sender, EventArgs e)
        {
            if (sportsSeats.Checked == true)
                sportsSeatsOption = " Sports Seats,";
            else
                sportsSeatsOption = "";
        }
        private void hillDescentControl_CheckedChanged(object sender, EventArgs e)
        {
            if (hillDescentControl.Checked == true)
                hillDescentControlOption = " Hill Descent Control,";
            else
                hillDescentControlOption = "";
        }
        private void audiVirtualCockpit_CheckedChanged(object sender, EventArgs e)
        {
            if (audiVirtualCockpit.Checked == true)
                audiVirtualCockpitOption = " Audi Virtual Cockpit,";
            else
                audiVirtualCockpitOption = "";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                voiceControlSystemOption = " Voice Control System,";
            else
                voiceControlSystemOption = "";
        }
        private void ventilatedFrontSeats_CheckedChanged(object sender, EventArgs e)
        {
            if (ventilatedFrontSeats.Checked == true)
                ventilatedFrontSeatsOption = " Ventilated Front Seats,";
            else
                ventilatedFrontSeatsOption = "";
        }
        //################################# END OF OPTIONS ###################################
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                audiCertifiedOption = "\nOn top of the original factory warranty of " +
                   "48 months/50,000 Miles! An extra 2 years/50,000 miles limited warranty, " +
                   "totaling the warranty to a 6-years/100,000 miles limited warranty!" +
                   " 24/7 Roadside Assistance at no additional charge!\n\n";
            else
                audiCertifiedOption = "";
        }
        private void audiCertifiedNO_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void fiveDaysMoneyBackYES_CheckedChanged(object sender, EventArgs e)
        {
            if (fiveDaysMoneyBackYES.Checked == true)
                fiveDaysMoneyBackOption = "Also comes with our industry leading " +
                   "5 day money back, 30 day/1,500 mile exchange policy. ";
            else
                fiveDaysMoneyBackOption = "";
        }
        private void fiveDaysMoneyBackNO_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void done_Click(object sender, EventArgs e)
        {
            string[] opt = new string[39];          
            //################################# PACKAGES ###################################
            opt[0] = coldWeatherPackageOption;
            opt[1] = sportPackageOption19;
            opt[2] = blackOpticPackageOption19;
            opt[3] = blackOpticPackageOption20;
            opt[4] = comfortSeatingPackageOption;
            opt[5] = warmWeatherPackageOption;
            opt[6] = wheelPackageOption20;
            opt[7] = driverAssistancePackageOption;
            opt[8] = a630TCompetitionPackageOption;
            //################################ OPTIONS ######################################
            opt[9] = template;
            opt[10] = equipedWithEquippedWOptions;
            opt[11] = blindSpotMonitoringOption;
            opt[12] = laneDepartureMonitoringOption;
            opt[13] = bluetoothPhoneConnectivityOption;
            opt[14] = siriusHdRadioOption;
            opt[15] = voiceControlSystemOption;
            opt[16] = navigationSystemOption;
            opt[17] = parkingAssistWBackupCameraAndParkingSensorsOption;
            opt[18] = rearviewCameraWifiOnlineServicesWAudiConnectOption;
            opt[19] = garageDoorOpenerKeylessEntryOption;
            opt[20] = collisionPreventionWAutomaticBreakingSystemOption;
            opt[21] = headUpDisplayWNavigationAndAssistanceSystemsInformationOption;
            opt[22] = audiPreSenseRearOption;
            opt[23] = hillDescentControlOption;
            opt[24] = automaticHeadlightsOption;
            opt[25] = threeZoneAutomaticClimateControlOption;
            opt[26] = heatedSeatsOption;
            opt[27] = heatedSteeringWheelOption;
            opt[28] = panoramicSunroofOption;
            opt[29] = adaptiveCruiseControlWithAutomaticStopNGoFunctionOption;
            opt[30] = audiVirtualCockpitOption;
            opt[31] = ventilatedFrontSeatsOption;
            opt[32] = sportsSeatsOption;
            opt[33] = bangNOlufsenHdPremiumSoundSystemOption;
            opt[34] = bossHdPremiumSoundSystemOption;
            opt[35] = andMuchMore;
            opt[36] = callToday;
            opt[37] = audiCertifiedOption;
            opt[38] = fiveDaysMoneyBackOption;
            if (fiveDaysMoneyBackYES.Checked == true || ldWeatherPackage.Checked == true || sportPackage19.Checked == true
                || driverAssistancePackage.Checked == true || blackOpticPackage19.Checked == true || blackOpticPackage.Checked == true
                || comfortSeatinPackage.Checked == true || competitionPackage.Checked == true ||warmWeatherPackage.Checked == true
                || wheelPackage.Checked == true || headUpDisplayWNavigationAndAssistanceSystemsInformation.Checked == true
                || siriusHDRadio.Checked == true || navigationSystem.Checked == true || audiPreSenseRear.Checked == true
                || blindSpotMonitoring.Checked == true || heatedSeats.Checked == true
                || heatedSeats.Checked == true || bangAndOlufsenHDPremiumSoundSystem.Checked == true || bangAndOlufsenHDPremiumSoundSystem.Checked == true
                || bLUETOOTHPhoneConnectivity.Checked == true || bLUETOOTHPhoneConnectivity.Checked == true || garageDoorOpenerKeylessEntry.Checked == true
                || laneDepartureMonitoring.Checked == true || automaticHeadlights.Checked == true || heatedSteeringWheel.Checked == true
                || threeZoneAutomaticClimateControl.Checked == true || collisionPreventionWAutomaticBreakingSystem.Checked == true
                || bossHDPremiumSoundSystem.Checked == true || parkingAssistWBackupCameraAndParkingSensors.Checked == true
                || RearviewCameraWIFIOnlineServicesWAudiConnect.Checked == true || adaptiveCruiseControlWithAutomaticStopGoFunction.Checked == true
                || panoramicSunroof.Checked == true || sportsSeats.Checked == true || hillDescentControl.Checked == true
                || audiVirtualCockpit.Checked == true || ventilatedFrontSeats.Checked == true || checkBox4.Checked == true || checkBox1.Checked == true)
            {
                text = opt[0] + opt[1] + opt[2] + opt[3] + opt[4] + opt[5] + opt[6] + opt[7]
                   + opt[8] + opt[9] + opt[10] + opt[11] + opt[12] + opt[13] + opt[14] + opt[15]
                   + opt[16] + opt[17] + opt[18] + opt[19] + opt[20] + opt[21] + opt[22] + opt[23]
                   + opt[24] + opt[25] + opt[26] + opt[27] + opt[28] + opt[29] + opt[30] + opt[31]
                   + opt[32] + opt[33] + opt[34] + opt[35] + opt[36] + opt[37]+opt[38]; 
                richTextBox1.Text = text;
            }
        }
        private void Bold_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
