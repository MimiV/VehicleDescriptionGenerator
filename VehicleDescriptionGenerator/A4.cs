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
    public partial class A4 : Form
    {
        Thread th;
        //################################# PACKAGES ###################################
        string premiumOption = "";
        string premiumPlusOption = "";
        string prestigeOption = "";
        string conveniencePackageOption = "";
        string sportPackageOption = "";
        string wheelPackage18Option = "";
        string wheelPackage19Option = "";
        string coldWeatherPackageOption = "";
        string sSportPackageOption = "";
        string blackOpticPlus19WheelPackageOption = "";
        string navigationAndTelematicsPackageOption = "";
        string sportPlusPackageOption = "";
        string blackOpticPlusPackageOption = "";
        string manualTransmissionOption = "";
        string driverAssistancePackageOption = "";
        string fineNappaLeatherPackageOption = "";
        string warmWeatherPackageOption = "";
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
        public A4()
        {
            InitializeComponent();
        }
        private void openHomeForm(object obj)
        {
            Application.Run(new Page1());
        }
        private void A4Home_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void goToA4Package_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void blackOpticPlusPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (blackOpticPlusPackage.Checked == true)
                blackOpticPlusPackageOption = "*Black Optic Plus Package\n";
            else
                blackOpticPlusPackageOption = "";
        }

        private void premiumPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (premiumPlus.Checked == true)
                premiumPlusOption = "*Premium Plus Package\n";
            else
                premiumPlusOption = "";
        }

        private void premium_CheckedChanged(object sender, EventArgs e)
        {
            if (premium.Checked == true)
                premiumOption = "*Premium Package\n";
            else
                premiumOption = "";
        }

        private void prestige_CheckedChanged(object sender, EventArgs e)
        {
            if (prestige.Checked == true)
                prestigeOption = "*Prestige Package\n";
            else 
                prestigeOption = "";
        }

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

        private void coldWeatherPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (coldWeatherPackage.Checked == true)
                coldWeatherPackageOption = "*Cold Weather Package\n";
            else
                coldWeatherPackageOption = "";
        }

        private void navigationAndTelematicsPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (navigationAndTelematicsPackage.Checked == true)
                navigationAndTelematicsPackageOption = "*Navigation and Telematics Package\n";
            else
                navigationAndTelematicsPackageOption = "";
        }

        private void sportPlusPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (sportPlusPackage.Checked == true)
                sportPlusPackageOption = "*Sport Plus Package\n";
            else
                sportPlusPackageOption = "";

        }

        private void warmWeatherPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (warmWeatherPackage.Checked == true)
                warmWeatherPackageOption = "*Warm Weather Package\n";
            else
                warmWeatherPackageOption = "";
        }

        private void fineNappaLeatherPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (fineNappaLeatherPackage.Checked == true)
                fineNappaLeatherPackageOption = "*Fine Nappa Leather Package\n";
            else
                fineNappaLeatherPackageOption = "";
        }

        private void SsportPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (SsportPackage.Checked == true)
                sSportPackageOption = "*S Sport Package\n";
            else
                sSportPackageOption = "";

        }

        private void driverAssistancePackage_CheckedChanged(object sender, EventArgs e)
        {
            if (driverAssistancePackage.Checked == true)
                driverAssistancePackageOption = "*Driver Assistance Package\n";
            else
                driverAssistancePackageOption = "";
        }

        private void wheelPackage19_CheckedChanged(object sender, EventArgs e)
        {
            if (wheelPackage19.Checked == true)
                wheelPackage19Option = "*19\" Wheel Package\n";
            else
                wheelPackage19Option = "";
        }

        private void blackOpticPlus19WheelPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (blackOpticPlus19WheelPackage.Checked == true)
                blackOpticPlus19WheelPackageOption = "*Black Optic Plus 19\" Wheel Package\n";
            else
                blackOpticPlus19WheelPackageOption = "";
        }

        private void manualTransmission_CheckedChanged(object sender, EventArgs e)
        {
            if (manualTransmission.Checked == true)
                manualTransmissionOption = "*Manual Transmission\n";
            else
                manualTransmissionOption = "";
        }
        //############################## END OF PACKAGES ################################
        private void A4_Load(object sender, EventArgs e)
        {

        }
        //################################# OPTIONS ###################################
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
            string[] opt = new string[47];
            //################################# PACKAGES ###################################          
            opt[0] = premiumOption;
            opt[1] = premiumPlusOption;
            opt[2] = prestigeOption;
            opt[3] = conveniencePackageOption;
            opt[4] = sportPackageOption;
            opt[5] = wheelPackage18Option;
            opt[6] = coldWeatherPackageOption;
            opt[7] = navigationAndTelematicsPackageOption;
            opt[8] = sportPlusPackageOption;
            opt[9] = blackOpticPlusPackageOption;
            opt[10] = manualTransmissionOption;
            opt[11] = blackOpticPlus19WheelPackageOption;
            opt[12] = wheelPackage19Option;
            opt[13] = driverAssistancePackageOption;
            opt[14] = sSportPackageOption;
            opt[15] = fineNappaLeatherPackageOption;
            opt[16] = warmWeatherPackageOption;
            //################################ OPTIONS ######################################
            opt[17] = template;
            opt[18] = equipedWithEquippedWOptions;
            opt[19] = blindSpotMonitoringOption;
            opt[20] = laneDepartureMonitoringOption;
            opt[21] = bluetoothPhoneConnectivityOption;
            opt[22] = siriusHdRadioOption;
            opt[23] = voiceControlSystemOption;
            opt[24] = navigationSystemOption;
            opt[25] = parkingAssistWBackupCameraAndParkingSensorsOption;
            opt[26] = rearviewCameraWifiOnlineServicesWAudiConnectOption;
            opt[27] = garageDoorOpenerKeylessEntryOption;
            opt[28] = collisionPreventionWAutomaticBreakingSystemOption;
            opt[29] = headUpDisplayWNavigationAndAssistanceSystemsInformationOption;
            opt[30] = audiPreSenseRearOption;
            opt[31] = hillDescentControlOption;
            opt[32] = automaticHeadlightsOption;
            opt[33] = threeZoneAutomaticClimateControlOption;
            opt[34] = heatedSeatsOption;
            opt[35] = heatedSteeringWheelOption;
            opt[36] = panoramicSunroofOption;
            opt[37] = adaptiveCruiseControlWithAutomaticStopNGoFunctionOption;
            opt[38] = audiVirtualCockpitOption;
            opt[39] = ventilatedFrontSeatsOption;
            opt[40] = sportsSeatsOption;
            opt[41] = bangNOlufsenHdPremiumSoundSystemOption;
            opt[42] = bossHdPremiumSoundSystemOption;
            opt[43] = andMuchMore;
            opt[44] = callToday;
            opt[45] = audiCertifiedOption;
            opt[46] = fiveDaysMoneyBackOption;

            if (fiveDaysMoneyBackYES.Checked == true || conveniencePackage.Checked == true || sportPackage.Checked == true || wheelPackage18.Checked == true
                || premium.Checked == true || premiumPlus.Checked == true || prestige.Checked == true
                || coldWeatherPackage.Checked == true || navigationAndTelematicsPackage.Checked == true || SsportPackage.Checked == true
                || sportPlusPackage.Checked == true || blackOpticPlusPackage.Checked == true || wheelPackage19.Checked == true
                || manualTransmission.Checked == true || headUpDisplayWNavigationAndAssistanceSystemsInformation.Checked == true
                || blackOpticPlus19WheelPackage.Checked == true || driverAssistancePackage.Checked == true || fineNappaLeatherPackage.Checked == true 
                || warmWeatherPackage.Checked == true ||siriusHDRadio.Checked == true || navigationSystem.Checked == true || navigationSystem.Checked == true
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
                   + opt[32] + opt[33] + opt[34] + opt[35] + opt[36] + opt[37] + opt[38] + opt[39] 
                   + opt[40] + opt[41] + opt[42] + opt[43] + opt[44] + opt[45] + opt[46];
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
        //SECOND PAGE HOME BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
