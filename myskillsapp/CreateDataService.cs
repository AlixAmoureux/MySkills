using myskillsapp.Object;
using System.Collections.Generic;

namespace myskillsapp
{
    public class CreateDataService
    {
        public static List<Language> GetLangageData()
        {
            List<Language> Languages = new List<Language>()
        {
            new Language(0, "C"),
            new Language(1, "C++"),
            new Language(2, "C#", new List<Framework>(new Framework[]{
                new Framework(0, "ASP.NET", new Language(2, "C#")),
                new Framework(1, "ASP.NET Core", new Language(2, "C#")),
                new Framework(2, ".NET (WPF, WinForms)", new Language(2, "C#")),
            })),
            new Language(3, "CSS", new List<Framework>(new Framework[]{
                new Framework(3, "Bootstrap", new Language(3, "CSS")),
            })),
            new Language(4, "HTML"),
            new Language(5, "Java", new List<Framework>(new Framework[]{
                new Framework(4, "Android", new Language(5, "Java")),
                new Framework(5, "JUnit", new Language(5, "Java")),
                new Framework(6, "Hibernate", new Language(5, "Java")),
                new Framework(7, "Spring", new Language(5, "Java")),
                new Framework(8, "Spring Boot", new Language(5, "Java")),
            })),
            new Language(6, "Javascript", new List<Framework>(new Framework[]{
                new Framework(9, "Angular JS", new Language(6, "Javascript")),
            })),
            new Language(7, "PHP", new List<Framework>(new Framework[]{
                new Framework(10, "Zend 2", new Language(7, "PHP")),
            })),
            new Language(8, "Python"),
            new Language(9, "SQL"),
            new Language(10, "Typescript", new List<Framework>(new Framework[]{
                new Framework(11, "Angular 2+ (4, 5, 8, 9)", new Language(10, "Typescript")),
            })),
            new Language(11, "XML"),
        };
            return Languages;
        }

        public static List<Software> GetSoftwaresData()
        {
            const string IDE = "IDE";
            const string SQL = "SQL";
            const string DBMS = "DBMS";
            const string HTTPSERVER = "HTTPSERVER";
            const string APITEST = "APITEST";
            const string OTHER = "OTHER";

            List<Software> Softwares = new List<Software>()
            {
                new Software(0, "Atom", IDE),
                new Software(1, "DBeaver", SQL),
                new Software(2, "Eclipse", IDE),
                new Software(3, "Git Extensions", OTHER),
                new Software(4, "IIS", HTTPSERVER),
                new Software(5, "Insomnia", APITEST),
                new Software(6, "Linux", OTHER),
                new Software(7, "MySQL", DBMS),
                new Software(8, "MySQL WorkBench", SQL),
                new Software(9, "NetBeans", IDE),
                new Software(10, "Oracle SQL Developer", SQL),
                new Software(11, "Postman", APITEST),
                new Software(12, "Soap UI", APITEST),
                new Software(13, "Spring Software Suite", IDE),
                new Software(14, "Microsoft SQL Server", DBMS),
                new Software(15, "SQL Server Management Studio", SQL),
                new Software(16, "Apache Tomcat", HTTPSERVER),
                new Software(17, "Visual Studio", IDE),
                new Software(18, "Visual Studio Code", IDE),
                new Software(19, "VmWare", OTHER),
                new Software(20, "WinSCP", OTHER),
                new Software(21, "PostgreSQL", DBMS),
                new Software(22, "MongoDB", DBMS),
                new Software(23, "MariaDB", DBMS),
                new Software(24, "Oracle Database", DBMS),
            };
            return Softwares;
        }
    }
}
