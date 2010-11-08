namespace TimeToGo.Services
{
    using System;

    public interface ITimeToGoNavigationService
    {
        void NavigateTo(Uri source);
        void EditInstant(Instant instant);
    }
}