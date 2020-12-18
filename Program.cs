/*
 * Rhona Filgeuras
 * Data (Study Application)
 *
 * October 26, 2020
 * 
 * ASCII Art by Donovan Bake
 * https://www.asciiart.eu/books/books
 * http://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Study%20Application%202.0
 * 
 * File Reader code from Canvas and Programming is Fun website
 * https://canvas.colum.edu/courses/19009/pages/code-example-i-slash-o-and-external-data?module_item_id=833166
 * http://programmingisfun.com/reading-writing-external-data-c-sharp-console-application/
 */

using System;
using System.IO;

namespace DataStudyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(170, 40); 
            Game studyApp = new Game();
            Game.Run();
        }
    }
}
