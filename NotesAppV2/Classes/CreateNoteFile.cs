using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NotesAppV2.Classes
{
    internal class CreateNoteFile
    {
        public void createFile()
        {
            //create a folder for notes
            //this will be removed at release, since there is no point in creating a new notes folder every time program is run
            string folderpath = "notes";
            System.IO.Directory.CreateDirectory(folderpath);
            //create a note
            //this will be run everytime when a new note file is to be created
            //this might be moved to mainwindow
            string path = "notes/testnote.txt";
            using (FileStream fs = File.Create(path));
        }
    }
}
