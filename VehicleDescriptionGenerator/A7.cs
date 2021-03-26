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
    public partial class A7 : Form
    {
        Thread th;
        //################################# PACKAGES ###################################
        string coldWeatherPackageOption = "";
        string sLineSportPackageOption = "";
        string driverAssistancePackageOption = "";
        string blackOpticPackageOption = "";
        string comfortSeatingPackageOption = "";
        string competitionPackageOption = "";
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

        public A7()
        {
            InitializeComponent();
        }

        private void A7_Load(object sender, EventArgs e)
        {

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
            panel3.Visible = true;
        }

        //A7 page
        private void goToA3Package_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void coldWeatherPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (coldWeatherPackage.Checked == true)
                coldWeatherPackageOption = "*Cold Weather Package\n";
            else
                coldWeatherPackageOption = "";
        }

        private void sLineSportPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (sLineSportPackage.Checked == true)
                sLineSportPackageOption = "*S Line Sport Package\n";
            else
                sLineSportPackageOption = "";
        }

        private void driverAssistancePackage_CheckedChanged(object sender, EventArgs e)
        {
            if (driverAssistancePackage.Checked == true)
                driverAssistancePackageOption = "*Driver Assistance Package\n";
            else
                driverAssistancePackageOption = "";
        }

        private void blackOpticPackage20_CheckedChanged(object sender, EventArgs e)
        {
            if (blackOpticPackage20.Checked == true)
                blackOpticPackageOption = "*20\" Black Optic Package\n";
            else
                blackOpticPackageOption = "";
        }

        private void comfortSeatingPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (comfortSeatingPackage.Checked == true)
                comfortSeatingPackageOption = "*Comfort Seating Package\n";
            else
                comfortSeatingPackageOption = "";
        }

        private void competitionPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (competitionPackage.Checked == true)
                competitionPackageOption = "*Competition Package\n";
            else
                competitionPackageOption = "";
        }

        private void sportsSeats_CheckedChanged(object sender, EventArgs e)
        {
            if (sportsSeats.Checked == true)
                sportsSeatsOption = " Sports Seats,";
            else
                sportsSeatsOption = "";
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
        //Voice Control
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
        private void fiveDaysMoneyBackYES_CheckedChanged(object sender, EventArgs e)
        {
            if (fiveDaysMoneyBackYES.Checked == true)
                fiveDaysMoneyBackOption = "Also comes with our industry leading " +
                    "5 day money back, 30 day/1,500 mile exchange policy. ";
            else
                fiveDaysMoneyBackOption = "";
        }

        private void done_Click(object sender, EventArgs e)
        {
            string[] opt = new string[36];           
            //################################# PACKAGES ###################################
            opt[0] = coldWeatherPackageOption;
            opt[1] = sLineSportPackageOption;
            opt[2] = driverAssistancePackageOption;
            opt[3] = blackOpticPackageOption;
            opt[4] = comfortSeatingPackageOption;
            opt[5] = competitionPackageOption;
            //################################ OPTIONS ######################################
            opt[6] = template;
            opt[7] = equipedWithEquippedWOptions;
            opt[8] = blindSpotMonitoringOption;
            opt[9] = laneDepartureMonitoringOption;
            opt[10] = bluetoothPhoneConnectivityOption;
            opt[11] = siriusHdRadioOption;
            opt[12] = voiceControlSystemOption;
            opt[13] = navigationSystemOption;
            opt[14] = parkingAssistWBackupCameraAndParkingSensorsOption;
            opt[15] = rearviewCameraWifiOnlineServicesWAudiConnectOption;
            opt[16] = garageDoorOpenerKeylessEntryOption;
            opt[17] = collisionPreventionWAutomaticBreakingSystemOption;
            opt[18] = headUpDisplayWNavigationAndAssistanceSystemsInformationOption;
            opt[19] = audiPreSenseRearOption;
            opt[20] = hillDescentControlOption;
            opt[21] = automaticHeadlightsOption;
            opt[22] = threeZoneAutomaticClimateControlOption;
            opt[23] = heatedSeatsOption;
            opt[24] = heatedSteeringWheelOption;
            opt[25] = panoramicSunroofOption;
            opt[26] = adaptiveCruiseControlWithAutomaticStopNGoFunctionOption;
            opt[27] = audiVirtualCockpitOption;
            opt[28] = ventilatedFrontSeatsOption;
            opt[29] = sportsSeatsOption;
            opt[30] = bangNOlufsenHdPremiumSoundSystemOption;
            opt[31] = bossHdPremiumSoundSystemOption;
            opt[32] = andMuchMore;
            opt[33] = callToday;
            opt[34] = audiCertifiedOption;
            opt[35] = fiveDaysMoneyBackOption;
        
            if (fiveDaysMoneyBackYES.Checked == true || coldWeatherPackage.Checked == true || sLineSportPackage.Checked == true
                ||driverAssistancePackage.Checked == true || blackOpticPackage20.Checked == true || comfortSeatingPackage.Checked == true
                ||competitionPackage.Checked == true || headUpDisplayWNavigationAndAssistanceSystemsInformation.Checked == true 
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
                   + opt[32] + opt[33] + opt[34] + opt[35];
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
