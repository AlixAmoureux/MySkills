using myskillsapp.Object;
using myskillsapp;
using NUnit.Framework;
using System.Collections.Generic;

namespace MySkills.UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly List<Language> _Languages;
        private Language _CSharpLanguage;
        private readonly List<Software> _Softwares;

        public UnitTests()
        {
            _Languages = CreateDataService.GetLangageData();
            _Softwares = CreateDataService.GetSoftwaresData();
        }

        [Test, Order(0)]
        public void LanguagesListNotNull()
        {
            Assert.IsNotNull(_Languages);
        }

        [Test, Order(1)]
        public void CSharpInList()
        {
            _CSharpLanguage = new Language(2, "C#");
            Language LanguageInList = _Languages.Find(Language => Language.Id == 2);
            Assert.AreEqual(_CSharpLanguage.Name, LanguageInList.Name);
        }

        [Test, Order(2)]
        public void CSharpContainsDotNetFramework()
        {
            Framework Framework = new Framework(2, ".NET (WPF, WinForms)", new Language(2, "C#"));
            Framework DotNetFramework = _Languages.Find(Language => Language.Id == 2).Framework.Find(Framework => Framework.Id == 2);
            Assert.That(Framework.Name.CompareTo(DotNetFramework.Name) == 0);
        }

        [Test, Order(3)]
        public void SoftwaresListNotNull()
        {
            Assert.IsNotNull(_Softwares);
        }

        [Test, Order(4)]
        public void SoftwaresListBeginsWithAtom()
        {
            Software TmpSoftware = _Softwares.Find(Software => Software.Id == 0);
            Assert.AreEqual(TmpSoftware.Name, "Atom");
        }

    }
}