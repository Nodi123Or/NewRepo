
using CodeExample.Service;

Console.WriteLine("Input M for middle string finder or H for markdown parser: ");

    string runApp = Console.ReadLine();

    switch (runApp)
    {
        case "M":
            RunnMiddleStringFinder();
            break;
        case "H":
            RunnHtmlCreator();
            break;
    }


 static void RunnHtmlCreator()
{
    string exit = string.Empty;

    do
    {
        try
        {
            Console.WriteLine("Write markdown text: ");

            string inputText = Console.ReadLine();

            string html = MarkdownParser.GetHtml(inputText);

            Console.WriteLine("Html string: " + html);

            Console.WriteLine("Press N to exit!");

            exit = Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    } while (exit != "N");
}

 static void RunnMiddleStringFinder()
{
    string exit = string.Empty;
    do
    {
        try
        {
            Console.WriteLine("Write text: ");

            string inputText = Console.ReadLine();

            string middleOfString = MiddleStringFinder.getMiddle(inputText);

            Console.WriteLine("Middle string: " + middleOfString);

            Console.WriteLine("Press N to exit!");

            exit = Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    } while (exit != "N");
}