try
{
    DirectoryInfo dirInfo = new DirectoryInfo(@"/" /* Или С:\\ для Windows */ );
    if (dirInfo.Exists)
    {
        Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
    }
  
    DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
    if (!newDirectory.Exists)
        newDirectory.Create();
  
    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
}
catch(Exception e)
{
    Console.WriteLine( e.Message);
}