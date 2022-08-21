///////////////////////////////////////////////////////////////////////////////////////////////
// File Name: MenuModel.cs
// File Description: Application Menu Model
// Program Type: C# MAUI
// Creator: home21cc@gmail.com
// Version: 0.0.0.1
// Create Date: 2022/08/09
// Final Update Date: 2022/08/09
///////////////////////////////////////////////////////////////////////////////////////////////

namespace ActiveGraphic.Models
{
    internal class MenuModel : object
    {
        public int Sequence { private set; get; }
        public string ChapterName { private set; get; }
        public string ContentNumber { private set; get; }
        public string ContentName { private set; get; }
        public string PageName { private set; get; }

        public MenuModel()
        {

        }

        public MenuModel(int sequence
            , string chapterName
            , string contentName
            , string contentNumber
            , string pageName)
        {
            Sequence = sequence;
            ChapterName = chapterName;
            ContentName = contentName;
            ContentNumber = contentNumber;
            PageName = pageName;
        }
    }
}
