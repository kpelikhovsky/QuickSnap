using System.Windows;
using System.Management;
using System.Drawing;

namespace QuickSnap
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

      private void MakeSnapshot_Click(object sender, RoutedEventArgs e)
      {
         ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
            "SELECT * FROM Win32_OperatingSystem");
         string sysinfo = null;
        foreach (ManagementObject queryObj in searcher.Get())
        {
           sysinfo += "---------------------------------\n";
           sysinfo += "Win32_OperatingSystem instance\n";
           sysinfo += "-----------------------------------\n";
           sysinfo += "BuildNumber: {0}" + queryObj["BuildNumber"] + "\n";
           sysinfo += "Caption: {0}" + queryObj["Caption"] + "\n";
           sysinfo += "FreePhysicalMemory: {0}" + queryObj["FreePhysicalMemory"] + "\n";
           sysinfo += "FreeVirtualMemory: {0}" + queryObj["FreeVirtualMemory"] + "\n";
           sysinfo += "Name: {0}" + queryObj["Name"] + "\n";
           sysinfo += "OSType: {0}" + queryObj["OSType"] + "\n";
           sysinfo += "RegisteredUser: {0}" + queryObj["RegisteredUser"] + "\n";
           sysinfo += "SerialNumber: {0}" + queryObj["SerialNumber"] + "\n";
           sysinfo += "ServicePackMajorVersion: {0}" + queryObj["ServicePackMajorVersion"] + "\n";
           sysinfo += "ServicePackMinorVersion: {0}" + queryObj["ServicePackMinorVersion"] + "\n";
           sysinfo += "Status: {0}" + queryObj["Status"] + "\n";
           sysinfo += "SystemDevice: {0}" + queryObj["SystemDevice"] + "\n";
           sysinfo += "SystemDirectory: {0}" + queryObj["SystemDirectory"] + "\n";
           sysinfo += "SystemDrive: {0}" + queryObj["SystemDrive"] + "\n";
           sysinfo += "Version: {0}" + queryObj["Version"] + "\n";
           sysinfo += "WindowsDirectory: {0}" + queryObj["WindowsDirectory"] + "\n";
        }
        SystemInfo.Text = sysinfo;

        // TODO: Add screenshot and send to server.
      }

   }
}
