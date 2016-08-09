namespace FreeTime.WebApp.ViewModels
{
    public interface IPages
    {
        int TotalPages { get; set; }
        int CurrentPage { get; set; }
        int PageSize { get; set; }
    }
}