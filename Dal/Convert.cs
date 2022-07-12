using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Convert
    {

        public static AddressConstraint ConvertToAddressConstraint(AddressConstraintDto a)
        {
            AddressConstraint addressConstraint = new AddressConstraint();
            addressConstraint.id = a.Id;
            addressConstraint.neighborhoodCode = a.NeighborhoodCode;
            addressConstraint.teacherId = a.TeacherId;
            return addressConstraint;
        }



        public static AddressConstraintDto ConvertToAddressConstraintDto(AddressConstraint a)
        {
            AddressConstraintDto addressConstraintDto = new AddressConstraintDto();
            addressConstraintDto.Id = a.id;
            addressConstraintDto.NeighborhoodCode = a.neighborhoodCode;
            addressConstraintDto.TeacherId = a.teacherId;
            return addressConstraintDto;

        }
        public static List<AddressConstraintDto> ConvertToAddressConstraintDtoList(List<AddressConstraint> a)
        {
            if (a == null)
                return null;
            List<AddressConstraintDto> addressConstraintDtoList = new List<AddressConstraintDto>();
            foreach (var addressConstraint in a)
            {
                addressConstraintDtoList.Add(ConvertToAddressConstraintDto(addressConstraint));
            }
            return addressConstraintDtoList;
        }
        public static Age ConvertToAge(AgeDto a)
        {
            Age age = new Age();
            age.ageCode = a.AgeCode;
            age.ageDescription = a.AgeDescription;
            return age;
        }
        public static AgeDto ConvertToAgeDto(Age a)
        {
            AgeDto ageDto = new AgeDto();
            ageDto.AgeCode = a.ageCode;
            ageDto.AgeDescription = a.ageDescription;
            return ageDto;
        }
        public static List<AgeDto> ConvertToAgeDtoList(List<Age> a)
        {
            if (a == null)
                return null;
            List<AgeDto> ageDtoList = new List<AgeDto>();
            foreach (var age in a)
            {
                ageDtoList.Add(ConvertToAgeDto(age));
            }
            return ageDtoList;
        }

        public static AgeConstraint ConvertToAgeConstraint(AgeConstraintDto a)
        {
            AgeConstraint ageConstraint = new AgeConstraint();
            ageConstraint.ageCode = a.AgeCode;
            ageConstraint.id = a.Id;
            ageConstraint.teacherId = a.TeacherId;
            return ageConstraint;
        }
        public static AgeConstraintDto ConvertToAgeConstraintDto(AgeConstraint a)
        {
            AgeConstraintDto ageConstraintDto = new AgeConstraintDto();
            ageConstraintDto.AgeCode = a.ageCode;
            ageConstraintDto.Id = a.id;
            ageConstraintDto.TeacherId = a.teacherId;
            return ageConstraintDto;
        }

        public static List<AgeConstraintDto> ConvertToAgeConstraintDtoList(List<AgeConstraint> a)
        {
            if (a == null)
                return null;
            List<AgeConstraintDto> ageConstraintDtoList = new List<AgeConstraintDto>();
            foreach (var ageConstraint in a)
            {
                ageConstraintDtoList.Add(ConvertToAgeConstraintDto(ageConstraint));
            }
            return ageConstraintDtoList;
        }
        public static City ConvertToCity(CityDto c)
        {
            City city = new City();
            city.cityCode = c.CityCode;
            city.cityName = c.CityName;
            return city;
        }

        public static CityDto ConvertToCityDto(City c)
        {
            CityDto cityDto = new CityDto();
            cityDto.CityCode = c.cityCode;
            cityDto.CityName = c.cityName;

            return cityDto;
        }
        public static List<CityDto> ConvertToCityDtoList(List<City> list)
        {
            if (list == null)
                return null;
            List<CityDto> cityDtoList = new List<CityDto>();
            foreach (var City in list)
            {
                cityDtoList.Add(ConvertToCityDto(City));
            }
            return cityDtoList;

        }

        public static Class ConvertToClass(ClassDto c)
        {
            Class class1 = new Class();
            class1.id = c.Id;
            class1.genderCode = c.GenderCode;
            class1.ageCode = c.AgeCode;
            class1.buildingNumber = c.BuildingNumber;
            class1.name = c.Name;
            class1.neighborhoodCode = c.NeighborhoodCode;
            class1.organizationCode = c.OrganizationCode;
            class1.street = c.Street;
            return class1;
        }
        public static ClassDto ConvertToClassDto(Class c)
        {
            ClassDto classDto = new ClassDto();
            classDto.AgeCode = c.ageCode;
            classDto.BuildingNumber = c.buildingNumber;
            classDto.GenderCode = c.genderCode;
            classDto.Id = c.id;
            classDto.Name = c.name;
            classDto.NeighborhoodCode = c.neighborhoodCode;
            classDto.Street = c.street;
            return classDto;
        }
        public static List<ClassDto> ConvertToClassDtoList(List<Class> list)
        {
            if (list == null)
                return null;
            List<ClassDto> classDtoList = new List<ClassDto>();
            foreach (var class1 in list)
            {
                classDtoList.Add(ConvertToClassDto(class1));
            }
            return classDtoList;
        }
        public static Day ConvertToDay(DayDto d)
        {
            Day day = new Day();
            day.dayCode = d.DayCode;
            day.dayName = d.DayName;
            return day;
        }
        public static DayDto ConvertToDayDto(Day d)
        {
            DayDto dayDto = new DayDto();
            dayDto.DayCode = d.dayCode;
            dayDto.DayName = d.dayName;
            return dayDto;
        }
        public static List<DayDto> ConvertToDayDtoList(List<Day> d)
        {
            if (d == null)
                return null;
            List<DayDto> dayDtoList = new List<DayDto>();
            foreach (var day in d)
            {
                dayDtoList.Add(ConvertToDayDto(day));
            }
            return dayDtoList;
        }

        public static DayConstraint ConvertToDayConstraint(DayConstraintDto d)
        {
            DayConstraint dayConstraint = new DayConstraint();
            dayConstraint.dayCode = d.DayCode;
            dayConstraint.id = d.Id;
            dayConstraint.teacherId = d.TeacherId;
            return dayConstraint;
        }
        public static DayConstraintDto ConvertToDayConstraintDto(DayConstraint d)
        {
            DayConstraintDto dayConstraintDto = new DayConstraintDto();
            dayConstraintDto.DayCode = d.dayCode;
            dayConstraintDto.Id = d.id;
            dayConstraintDto.TeacherId = d.teacherId;
            return dayConstraintDto;
        }
        public static List<DayConstraintDto> ConvertToDayConstraintDtoList(List<DayConstraint> d)
        {
            if (d == null)
                return null;
            List<DayConstraintDto> dayConstraintDtoList = new List<DayConstraintDto>();
            foreach (var dayConstraint in d)
            {
                dayConstraintDtoList.Add(ConvertToDayConstraintDto(dayConstraint));
            }
            return dayConstraintDtoList;
        }


    
        public static Gender ConvertToGender(GenderDto g)
        {
            Gender gender = new Gender();
            gender.genderCode = g.GenderCode;
            gender.genderDescription = g.GenderDescription;
            return gender;
        }
        public static GenderDto ConvertToGenderDto(Gender g)
        {
            GenderDto genderDto = new GenderDto();
            genderDto.GenderCode = g.genderCode;
            genderDto.GenderDescription = g.genderDescription;
            return genderDto;
        }
        public static List<GenderDto> ConvertToGenderDtoList(List<Gender> g)
        {
            if (g == null)
                return null;
            List<GenderDto> genderDtoList = new List<GenderDto>();
            foreach (var gender in g)
            {
                genderDtoList.Add(ConvertToGenderDto(gender));
            }
            return genderDtoList;
        }
        public static GenderConstraint ConvertToGenderConstraint(GenderConstraintDto g)
        {
            GenderConstraint genderConstraint = new GenderConstraint();
            genderConstraint.genderCode = g.GenderCode;
            genderConstraint.id = g.Id;
            genderConstraint.teacherId = g.TeacherId;
            return genderConstraint;
        }
        public static GenderConstraintDto ConvertToGenderConstraintDto(GenderConstraint g)
        {
            GenderConstraintDto genderConstraintDto = new GenderConstraintDto();
            genderConstraintDto.Id = g.id;
            genderConstraintDto.TeacherId = g.teacherId;
            genderConstraintDto.GenderCode = g.genderCode;
            return genderConstraintDto;
        }
        public static List<GenderConstraintDto> ConvertToGenderConstraintDtoList(List<GenderConstraint> g)
        {
            if (g == null)
                return null;
            List<GenderConstraintDto> genderConstraintDtoList = new List<GenderConstraintDto>();
            foreach (var genderConstraint in g)
            {
                genderConstraintDtoList.Add(ConvertToGenderConstraintDto(genderConstraint));
            }
            return genderConstraintDtoList;
        }
        public static Neighborhood ConvertToGenderConstraint(NeighborhoodDto n)
        {
            Neighborhood neighborhood = new Neighborhood();
            neighborhood.cityCode = n.CityCode;
            neighborhood.neighborhoodCode = n.NeighborhoodCode;
            neighborhood.neighborhoodName = n.NeighborhoodName;
            return neighborhood;
        }
        public static NeighborhoodDto ConvertToNeighborhoodDto(Neighborhood n)
        {
            NeighborhoodDto neighborhoodDto = new NeighborhoodDto();
            neighborhoodDto.CityCode = n.cityCode;
            neighborhoodDto.CityName = "jerus";
            neighborhoodDto.NeighborhoodCode = n.neighborhoodCode;
            neighborhoodDto.NeighborhoodName = n.neighborhoodName;
            return neighborhoodDto;
        }
        public static List<NeighborhoodDto> ConvertToNeighborhoodDtoList(List<Neighborhood> n)
        {
            if (n == null)
                return null;
            List<NeighborhoodDto> neighborhoodDtoList = new List<NeighborhoodDto>();
            foreach (var neighborhood in n)
            {
                neighborhoodDtoList.Add(ConvertToNeighborhoodDto(neighborhood));
            }
            return neighborhoodDtoList;
        }
        public static Organization ConvertToOrganization(OrganizationDto o)
        {
            Organization organization = new Organization();
            organization.organizationCode = o.OrganizationCode;
            organization.organizationName = o.OrganizationName;
            return organization;
        }
        public static OrganizationDto ConvertToNeighborhoodDto(Organization o)
        {
            OrganizationDto organizationDto = new OrganizationDto();
            organizationDto.OrganizationCode = o.organizationCode;
            organizationDto.OrganizationName = o.organizationName;
            return organizationDto;
        }

  
        public static Teacher ConvertToTeacher(TeacherDto t)
        {
            Teacher teacher = new Teacher();
            teacher.buildingNumber = t.BuildingNumber;
            teacher.email = t.Email;
            teacher.firstName = t.FirstName;
            teacher.id = t.Id;
            teacher.lastName = t.LastName;
            teacher.neighborhoodCode = t.NeighborhoodCode;
            teacher.password = t.Password;
            teacher.phone = t.Phone;
            teacher.street = t.Street;
            return teacher;
        }
        public static List<TeacherDto> ConvertToTeacherDtoList(List<Teacher> list)
        {
            if (list == null)
                return null;
            List<TeacherDto> TeacherDtoList = new List<TeacherDto>();
            foreach (var teacher in list)
            {
                TeacherDtoList.Add(ConvertToTeacherDto(teacher));
            }
            return TeacherDtoList;
        }
        public static TeacherDto ConvertToTeacherDto(Teacher t)
        {
            TeacherDto teacherDto = new TeacherDto();
            teacherDto.BuildingNumber = t.buildingNumber;
            teacherDto.Email = t.email;
            teacherDto.FirstName = t.firstName;
            teacherDto.Id = t.id;
            teacherDto.LastName = t.lastName;
            teacherDto.NeighborhoodCode = t.neighborhoodCode;
            teacherDto.Password = t.password;
            teacherDto.Phone = t.phone;
            teacherDto.Street = t.street;
            return teacherDto;
        }


 
        public static Exchanging ExchangingDtoToExchanging(ExchangingDto e)
        {
            Exchanging exchanging = new Exchanging();
            exchanging.id = e.Id;
            exchanging.is_exchaning = e.IsExchanging;
            exchanging.sourceDate = DateTime.Parse(e.SourceDate);
            exchanging.substituteTeacherId = e.SubstituteTeacherId;
            exchanging.teacherId = e.TeacherId;
            exchanging.classId = e.ClassId;
            exchanging.ask_id = e.AskId;
            exchanging.is_relevant = e.IsRelevant;
            if (e.DestinationDate!=null)
                exchanging.destinationDate = DateTime.Parse(e.DestinationDate);
            return exchanging;
        }
        public static ExchangingDto ExchangingToExchangingDto(Exchanging exchanging)
        {
            ExchangingDto e = new ExchangingDto();
            e.Id = exchanging.id;
            e.ClassId = exchanging.classId;
            e.AskId =exchanging.ask_id ;
            e.ClassName = exchanging.Class.name;
            e.SourceDate = String.Format("{0:d/M/yyyy}", exchanging.sourceDate);
            e.SourceDayName = GetDayName(exchanging.sourceDate.DayOfWeek);
            e.TeacherName = exchanging.Teacher.firstName + " " + exchanging.Teacher.lastName;
            e.TeacherId = exchanging.teacherId;
            e.IsExchanging = exchanging.is_exchaning;
            e.IsRelevant = exchanging.is_relevant;
            e.AskId = exchanging.ask_id;
            e.ClassAddress = exchanging.Class.street + " " + exchanging.Class.buildingNumber + ", " + exchanging.Class.Neighborhood.City.cityName;
            if (exchanging.is_exchaning == true)
            {
                if (exchanging.destinationDate == null)
                    e.Message = "ממלאת מקום של ";
                else
                    e.Message = "מחליפה עם ";

            }
            else
            {

                if (exchanging.destinationDate == null)
                    e.Message = "מחפשת מילוי מקום  ";
                else
                    e.Message = "מחפשת מחליפה";

            }
            if (exchanging.substituteTeacherId.HasValue)
            {
                e.SubstituteTeacherName = exchanging.Teacher1.firstName + " " + exchanging.Teacher1.lastName;
                e.SubstituteTeacherId = exchanging.substituteTeacherId;

            }
            if (exchanging.destinationDate.HasValue)
            {
                DateTime dt = (DateTime)exchanging.destinationDate;
                e.DestinationDayName = GetDayName(dt.DayOfWeek);
                e.DestinationDate = String.Format("{0:d/M/yyyy}", exchanging.destinationDate);

            }
            return e;
        }
        private static string GetDayName(DayOfWeek? dayOfWeek)
        {
            switch ((int)dayOfWeek)
            {
                case 0: return "יום ראשון";
                case 1: return "יום שני";
                case 2: return "יום שלישי";
                case 3: return "יום רביעי";
                default: return "יום חמישי";
            }
        }
    }
}
