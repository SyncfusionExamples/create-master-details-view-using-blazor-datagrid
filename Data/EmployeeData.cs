using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Master_Detail_Grid.Data
{
    public class Salesperson
    {
        public int? EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postal { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public static List<Salesperson> GetSalesperson()
        {
            List<Salesperson> Employees = new List<Salesperson>
            {
                new Salesperson {EmployeeID = 1, FirstName="Nancy", LastName="Andrea", Email="nancy.andr@gmail.com", Title="Sales Representative",City="New York", Country="USA", Postal="10007", Address="507 - 20th Ave. E. Apt. 2A", Phone="(212) 555-1189"},
                new Salesperson {EmployeeID = 2, FirstName="Andrew", LastName="Taylor", Email="andrew.taylor@gmail.com", Title="Vice President",City="London", Country="UK", Postal="WC2H 0HH", Address="908 W. Capital Way", Phone="(71) 755-9489"},
                new Salesperson {EmployeeID = 3, FirstName="Jenie", LastName="Celine", Email="celine_jeny@gmail.com", Title="Region Manager",City="London", Country="UK", Postal="WC2H 0HH", Address="722 Moss Bay Blvd.", Phone="(71) 235-5644"},
                new Salesperson {EmployeeID = 4, FirstName="Margaret", LastName="Lucy", Email="margaret.lucy@gmail.com", Title="Sales Manager",City="London", Country="UK", Postal="WC2H 0HH", Address="4110 Old Redmond Rd.", Phone="(71) 555-4674"},
                new Salesperson {EmployeeID = 5, FirstName="Steven", LastName="Stalen", Email="staley.steve@gmail.com", Title="Sales VP",City="Vegas", Country="USA", Postal="89107", Address="14 Garrett Hill", Phone="(212) 555-1189"},
                new Salesperson {EmployeeID = 6, FirstName="Smith", LastName="Joe", Email="joe.smith@gmail.com", Title="Sales Consultant",City="New York", Country="USA", Postal="10007", Address="Coventry House Miner Rd.", Phone="(212) 555-1189"},
                new Salesperson {EmployeeID = 7, FirstName="Steven", LastName="Smith", Email="smith.steve@gmail.com", Title="Sales Coordinator",City="Paris", Country="France", Postal="75007", Address="Edgeham Hollow Winchester Way", Phone="+331 4025 0808"},
                new Salesperson {EmployeeID = 8, FirstName="Catherine", LastName="Ray", Email="ray_catherine@gmail.com", Title="Sales Representative",City="Mumbai", Country="India", Postal="400007", Address="4726 - 11th Ave. N.E.", Phone="022 43768823"},
                new Salesperson {EmployeeID = 9, FirstName="Larry", LastName="Reas", Email="raes_larry@gmail.com", Title="Sales Associate",City="Chennai", Country="India", Postal="600077", Address="7 Houndstooth Rd.", Phone="044 41618442"}
            };
            return Employees;
        }
    }

    public class Location
    {
        public double latitude;
        public double longitude;
        public string name;

        public static List<Location> GetLocation()
        {
            List<Location> MapPoints = new List<Location> {
                new Location { name= "New York",  latitude= 40.7488758, longitude= -73.9730091 },
                new Location { name = "London", latitude= 51.5074, longitude= -0.1278,},
                new Location { name = "Vegas", latitude=36.1699, longitude= -115.1398,},
                new Location { name="Paris", latitude= 48.8773406, longitude= 2.3299627,},
                new Location { name="Mumbai", latitude= 19.1555762, longitude= 72.8849595,},
                new Location { name="Chennai", latitude=13.0827, longitude= 80.2707,}
            };
            return MapPoints;
        }
    }

    public class MeetingSchedule
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? EID { get; set; }

        public static List<MeetingSchedule> GetMeetingData()
        {
            List<MeetingSchedule> ScheduleData = new List<MeetingSchedule>
            {
                new MeetingSchedule { Id = 1, Subject="Meeting with Alex", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 1 },
                new MeetingSchedule { Id = 2, Subject="Meeting with Bob", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 1 },
                new MeetingSchedule { Id = 3, Subject="Meeting with Catherine", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 2 },
                new MeetingSchedule { Id = 4, Subject="Meeting with Dany", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 2 },
                new MeetingSchedule { Id = 5, Subject="Meeting with Eliot", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 3 },
                new MeetingSchedule { Id = 6, Subject="Meeting with Frezey", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 3 },
                new MeetingSchedule { Id = 7, Subject="Meeting with Goldie", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 4 },
                new MeetingSchedule { Id = 8, Subject="Meeting with Harman", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 4 },
                new MeetingSchedule { Id = 9, Subject="Meeting with Irwin", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 5 },
                new MeetingSchedule { Id = 10, Subject="Meeting with Jack", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 5 },
                new MeetingSchedule { Id = 11, Subject="Meeting with Klay", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 6 },
                new MeetingSchedule { Id = 12, Subject="Meeting with Lucy", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 6 },
                new MeetingSchedule { Id = 13, Subject="Meeting with Moni", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 7 },
                new MeetingSchedule { Id = 14, Subject="Meeting with Nancy", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 7 },
                new MeetingSchedule { Id = 15, Subject="Meeting with Orley", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 8 },
                new MeetingSchedule { Id = 16, Subject="Meeting with Prince", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 8 },
                new MeetingSchedule { Id = 17, Subject="Meeting with Queen", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 9 },
                new MeetingSchedule { Id = 18, Subject="Meeting with Rockstar", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 9 }
            };
            return ScheduleData;
        }
    }

    public class Orders
    {
        public int? EmployeeID { get; set; }
        public int? OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
        public double? Freight { get; set; }
    }
}
