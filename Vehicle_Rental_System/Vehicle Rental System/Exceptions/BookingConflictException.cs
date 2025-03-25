namespace Vehicle_Rental_System.Exceptions
{
    public class BookingConflictException : Exception
    {
        public BookingConflictException()
        {
            
        }
        public BookingConflictException(string message) : base(message)
        {
        }
    }
}
