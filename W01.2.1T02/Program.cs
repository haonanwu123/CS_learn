namespace W01._2._1T02;

static class Program
{
    static void Main()
    {
        List<string> fileList = [
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        ];

        while (fileList.Count > 0)
        {
            string whichFileToDelete = fileList[0];

            Console.WriteLine("File selected to delete: " + whichFileToDelete);

            string confirm;

            do
            {
                Console.WriteLine("Really delete this file? (y/n)");
                confirm = Console.ReadLine()!.Trim();
            }
            while (confirm != "n" && confirm != "y");

            if (confirm == "y")
            {
                fileList.Remove(whichFileToDelete);
                Console.WriteLine("File deleted");
            }

            break;
        }
    }
}
