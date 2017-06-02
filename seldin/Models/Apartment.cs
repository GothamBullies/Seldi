using System;
using System.Collections.Generic;
using System.Linq;

namespace seldin.Models
{
    public class Apartment
    {
        private string _apartmentImagesFolder = "/Assets/images/apartment-images/";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string OfficeHours { get; set; }
        public string ByAppointment { get; set; }
        public string telephone { get; set; }
        public int NoOfBeds { get; set; }
        public int NoOfBaths { get; set; }
        public string email { get; set; }
        public string ImageFileName { get; set; }
        public string CoverImageFileName { get; set; }
        public Array Image { get; set; }

        public Category Category { get; set; }

        public List<Apartment> GetApartments()
        {
            var category = new Category();
            var categories = category.GetCategories();

            return new List<Apartment>()
            {
                new Apartment()
                {
                    Id = 1,
                    Name = "Village East",
                    Description = "Village East (Senior Living 55+) in Omaha, Nebraska," + "" + " offers residents comfort, happiness and relaxtion. Green Rooftop Patio, Private Sun Room, and Fully Equipped Kitchens will put you at ease. Residents enjoy beautiful views of Downtown Omaha while planting their own vegetables/fruits in the garden. Village East is conveniently located near Medical Facilities, easy access to Highway 75 and Public Transportation. Visit our community today to see why our residents are proud to call Village East home.",
                    NoOfBeds = 2,
                    Address = "2011 North 25th Street • Omaha, NE 68111",
                    OfficeHours = "",
                    ByAppointment = "",
                    telephone = "(402) 679-3229",
                    NoOfBaths = 1,
                    Category = categories.Where(x => x.Id == 1).FirstOrDefault(),
                    ImageFileName = "ap-1.jpg",
                    CoverImageFileName = "ap-1-cover.JPG",
                    email = "mailto:villageeast@seldin.com",
                    Image = new[]
                    {
                        $"{_apartmentImagesFolder}1-1.jpg",
                        $"{_apartmentImagesFolder}1-2.jpg",
                        $"{_apartmentImagesFolder}1-3.jpg",
                        $"{_apartmentImagesFolder}1-4.jpg",
                        $"{_apartmentImagesFolder}1-5.jpg",
                        $"{_apartmentImagesFolder}1-6.jpg",
                    }

                },
                new Apartment()
                {
                    Id = 2,
                    Name = "Rennaisance Village",
                    Description = "Welcome Home Renaissance Village is located right next to Bemis Park and is only minutes away from Highway 75 and Interstate 480. Enjoy the outdoors at your doorstep with the area's mature trees and manicured lawns. These homes include studio, two and three bedroom floor plans. Renaissance Village could be the future home for you!",
                    NoOfBeds = 6,
                    NoOfBaths = 3,
                    Address = "3612 Cuming St Omaha, NE 68131",
                    OfficeHours = "",
                    ByAppointment = "",
                    telephone = "(402) 898-5879",
                    Category = categories.Where(x => x.Id == 2).FirstOrDefault(),
                    ImageFileName = "ap-2.jpg",
                    email = "Renaissancevillage@seldin.com",
                    Image = new[]
                    {
                        $"{_apartmentImagesFolder}2-1.jpg",
                        $"{_apartmentImagesFolder}2-2.jpg",
                        $"{_apartmentImagesFolder}2-3.jpg"
                    }
                },
                new Apartment()
                {
                    Id = 3,
                    Name = "THE RESERVES AT PRESTON TRAILS",
                    Description = "Looking for a luxury apartment at an affordable price? Welcome to The Reserves at Preston Trails! Located in the fast growing city of Wolfforth, TX, The Reserves at Preston Trails has all the amenities and high-end finishes residents are looking for in a place to call home. From the resort-style salt water pool, in-house movie theater and community fitness center, to spacious interior and exterior living spaces... what’s not to love? Find out more about The Reserves at Preston Trails, and why you’ll want to call it home.",
                    NoOfBeds = 2,
                    Address = "7300 Alcove Ave Wolfforth, TX 79407",
                    OfficeHours = "Mon-Fri 8:30 am - 5:30 pm",
                    ByAppointment = "Sat 8:30 am - 5:30 am",
                    telephone = "806-243-2531",
                    NoOfBaths = 1,
                    Category = categories.Where(x => x.Id == 1).FirstOrDefault(),
                    ImageFileName = "ap-1.jpg",
                    email = "",
                    Image = new[]
                    {
                        $"{_apartmentImagesFolder}3-1.jpg",
                        $"{_apartmentImagesFolder}3-2.jpg",
                        $"{_apartmentImagesFolder}3-3.jpg",
                        $"{_apartmentImagesFolder}3-4.jpg",
                        $"{_apartmentImagesFolder}3-5.jpg"
                    }
                }
            };
        }
    }
}