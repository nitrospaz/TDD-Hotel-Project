using Shouldly;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RoomBookingApp.Core
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void ShouldReturnRoomBookingResponseWithValues()
        {
            // Arrange ---

            // mock data
            var bookingRequest = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@request.com",
                Date = new DateTime(2021, 1, 1)
            };

            // instantiate the processor
            var processor = new RoomBookingRequestProcessor();


            // Act --- 
            RoomBookingResult result = processor.BookRoom(bookingRequest);


            // Assert --- 
            Assert.NotNull(result); // xunit assertion
            result.ShouldNotBeNull(); // shouldly assertion
        }
    }
}
