using System.Diagnostics;

try
{
    //new Thread(() =>
    //{
    //    while (true)
    //    {
    //        Console.WriteLine("open notepad");
    //        Console.WriteLine(Directory.GetCurrentDirectory());
    //        Process.Start("notepad.exe").WaitForExit();
    //    }

    //}).Start();

    new Thread(() =>
    {
        //while (true)
        //{ }
        Console.WriteLine(@"cd " + Directory.GetCurrentDirectory() + " & start.bat");
        Process myProcess = new Process();
        myProcess.StartInfo.FileName = "cmd.exe";
        myProcess.StartInfo.Arguments = @"cd " + Directory.GetCurrentDirectory() + "& start.bat";
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        myProcess.StartInfo.CreateNoWindow = true;
        myProcess.Start();


    }).Start();


}
catch (Exception ex)
{
    System.Console.WriteLine(ex.ToString());
}