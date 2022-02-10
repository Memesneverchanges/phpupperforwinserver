using System.Diagnostics;

    //new Thread(() =>
    //{
    //    while (true)
    //    {
    //        Console.WriteLine("open notepad");
    //        Console.WriteLine(Directory.GetCurrentDirectory());
    //        Process.Start("notepad.exe").WaitForExit();
    //    }

    //}).Start();

    Thread proc = new Thread(() =>
    {
        int t = 0;
        Console.WriteLine(@"cd " + Directory.GetCurrentDirectory() + " & start.bat");
        Process myProcess = new Process();
        myProcess.StartInfo.FileName = "cmd.exe";
        myProcess.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
        myProcess.StartInfo.Arguments = "/c" + "cd " + Directory.GetCurrentDirectory() + "& start.bat";
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        myProcess.StartInfo.UseShellExecute = false;
        myProcess.StartInfo.CreateNoWindow = true;
        while (t < 100)
        {
            myProcess.Start();
            myProcess.WaitForExit();
            t++;
            Console.WriteLine(t.ToString());
        }
        return;
    });
    proc.Start();
