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
    public partial class A3 : Form
    {
        Thread th;
        //################################# PACKAGES ###################################
        string conveniencePackageOption = "";
        string sportPackageOption = "";
        string wheelPackage18Option = "";
        string technologyPackageOption = "";
        string ledLightingPackageOption = "";
        string wheelPackage19Option = "";
        string coldWeatherPackageOption = "";
        string sSporSeatPackageOption = "";
        string sSportPackageOption = "";
        string blackOpticDynamicPackageOption = "";

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
        string callToday = " Call today to schedule a no obligation test drive!\n\n";
        string andMuchMore = " and so much more!";
        string template = "\nThis Herb Chambers Certified Pre-owned Vehicle has received a rigorous " +
             "multi-point inspection by our factory trained technicians, and then professionally detailed. " +
             "Receipt and complete pre-owned portfolio will be provided when you visit for your test drive.\n";
        string text = "";

        public A3()
        {
            InitializeComponent();
        }

        private void A3Home_Click(object sender, EventArgs e)
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

        //################################# PACKAGES ###################################
        private void conveniencePackage_CheckedChanged(object sender, EventArgs e)
        {
            if (conveniencePackage.Checked == true)
                conveniencePackageOption = "*Convenience Package\n";

            else
                conveniencePackageOption = "";
        }

        private void sportPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (sportPackage.Checked == true)
                sportPackageOption = "*Sport Package\n";
            else
                sportPackageOption = "";
        }

        private void wheelPackage18_CheckedChanged(object sender, EventArgs e)
        {
            if (wheelPackage18.Checked == true)
                wheelPackage18Option = "*18\" Wheel Package\n";
            else
                wheelPackage18Option = "";
        }

        private void technologyPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (technologyPackage.Checked == true)
                technologyPackageOption = "*Technology Package\n";
            else
                technologyPackageOption = "";
        }

        private void LEDlightingPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (LEDlightingPackage.Checked == true)
                ledLightingPackageOption = "*LED Lighting Package\n";
            else
                ledLightingPackageOption = "";
        }

        private void WheelPackage19_CheckedChanged(object sender, EventArgs e)
        {
            if (WheelPackage19.Checked == true)
                wheelPackage19Option = "*19\" Wheel Package\n";
            else
                wheelPackage19Option = "";
        }

        private void coldWeatherPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (coldWeatherPackage.Checked == true)
                coldWeatherPackageOption = "*Cold Weather Package\n";
            else
                coldWeatherPackageOption = "";
        }
        
        private void SsportSeatPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (SsportSeatPackage.Checked == true)
                sSporSeatPackageOption = "*S Sport Seat Package\n";
            else
                sSporSeatPackageOption = "";

        }

        private void SsportPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (SsportPackage.Checked == true)
                sSportPackageOption = "*S Sport Package\n";
            else
                sSportPackageOption = "";
        }

        private void blackOpticDynamicPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (blackOpticDynamicPackage.Checked == true) 
                blackOpticDynamicPackageOption = "*Black Optic Dynamic Package\n"; 
            else
                blackOpticDynamicPackageOption = "";
        }
        //############################## END OF PACKAGES ################################
        private void a3Next_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void goToA3Package_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        //################################# OPTIONS ###################################
        private void headUpDisplayWNavigationAndAssistanceSystemsInformation_CheckedChanged(object sender, EventArgs e)
        {
            if (headUpDisplayWNavigationAndAssistanceSystemsInformation.Checked == true) { 
                headUpDisplayWNavigationAndAssistanceSystemsInformationOption =
                " Head-up Display with Navigation and Assistance Systems Information,";}
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
            if(automaticHeadlights.Checked == true)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                voiceControlSystemOption = " Voice Control System,";
            else
                voiceControlSystemOption = "";
        }
        private void audiVirtualCockpit_CheckedChanged(object sender, EventArgs e)
        {
            if (audiVirtualCockpit.Checked == true)
                audiVirtualCockpitOption = " Audi Virtual Cockpit,";
            else
                audiVirtualCockpitOption = "";
        }
        private void ventilatedFrontSeats_CheckedChanged(object sender, EventArgs e)
        {
            if(ventilatedFrontSeats.Checked == true)
            ventilatedFrontSeatsOption = " Ventilated Front Seats,";
            else
            ventilatedFrontSeatsOption = "";
        }
         //################################# END OF OPTIONS ###################################
        //Audi Certified YES
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                audiCertifiedOption = "On top of the original factory warranty of " +
                   "48 months/50,000 Miles! An extra 2 years/50,000 miles limited warranty, " +
                   "totaling the warranty to a 6-years/100,000 miles limited warranty!" +
                   " 24/7 Roadside Assistance at no additional charge!\n\n";
            else
                audiCertifiedOption = "";
        }

        private void audiCertifiedNO_CheckedChanged(object sender, EventArgs e)
        {

        }

        //5 DAYS MONEY BACK
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

        private void Bold_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void done_Click(object sender, EventArgs e)
        {
            string[] opt = new string[40];
            //################################# PACKAGES ###################################           
            opt[0] = conveniencePackageOption;
            opt[1] = sportPackageOption;
            opt[2] = wheelPackage18Option;
            opt[3] = technologyPackageOption;
            opt[4] = ledLightingPackageOption;
            opt[5] = wheelPackage19Option;
            opt[6] = coldWeatherPackageOption;
            opt[7] = sSporSeatPackageOption;
            opt[8] = sSportPackageOption;
            opt[9] = blackOpticDynamicPackageOption;
            //################################# OPTIONS ######################################
            opt[10] = template;
            opt[11] = equipedWithEquippedWOptions;
            opt[12] = blindSpotMonitoringOption;
            opt[13] = laneDepartureMonitoringOption;
            opt[14] = bluetoothPhoneConnectivityOption;
            opt[15] = siriusHdRadioOption;
            opt[16] = voiceControlSystemOption;
            opt[17] = navigationSystemOption;
            opt[18] = parkingAssistWBackupCameraAndParkingSensorsOption;
            opt[19] = rearviewCameraWifiOnlineServicesWAudiConnectOption;
            opt[20] = garageDoorOpenerKeylessEntryOption;
            opt[21] = collisionPreventionWAutomaticBreakingSystemOption;
            opt[22] = headUpDisplayWNavigationAndAssistanceSystemsInformationOption;
            opt[23] = audiPreSenseRearOption;
            opt[24] = hillDescentControlOption;
            opt[25] = automaticHeadlightsOption;
            opt[26] = threeZoneAutomaticClimateControlOption;
            opt[27] = heatedSeatsOption;
            opt[28] = heatedSteeringWheelOption;
            opt[29] = panoramicSunroofOption;
            opt[30] = adaptiveCruiseControlWithAutomaticStopNGoFunctionOption;
            opt[31] = audiVirtualCockpitOption;
            opt[32] = ventilatedFrontSeatsOption;
            opt[33] = sportsSeatsOption;
            opt[34] = bangNOlufsenHdPremiumSoundSystemOption;
            opt[35] = bossHdPremiumSoundSystemOption;           
            opt[36] = andMuchMore;
            opt[37] = callToday;
            opt[38] = audiCertifiedOption;
            opt[39] = fiveDaysMoneyBackOption;

            if (fiveDaysMoneyBackYES.Checked == true || conveniencePackage.Checked == true || sportPackage.Checked == true || wheelPackage18.Checked == true 
                || technologyPackage.Checked == true || LEDlightingPackage.Checked == true || WheelPackage19.Checked == true
                || coldWeatherPackage.Checked == true || SsportSeatPackage.Checked == true || SsportPackage.Checked == true
                || blackOpticDynamicPackage.Checked == true || headUpDisplayWNavigationAndAssistanceSystemsInformation.Checked == true
                || siriusHDRadio.Checked == true || navigationSystem.Checked == true || navigationSystem.Checked == true
                || audiPreSenseRear.Checked == true || blindSpotMonitoring.Checked == true || heatedSeats.Checked == true
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
                    + opt[32] + opt[33] + opt[34] + opt[35] + opt[36] + opt[37] + opt[38] + opt[39];
                richTextBox1.Text = text;
            }
        }
        //2ND PAGE HOME BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
