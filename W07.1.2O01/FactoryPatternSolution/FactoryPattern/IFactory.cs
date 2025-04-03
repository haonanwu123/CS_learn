public interface IFactory<T>
{
    T CreateLightTheme();
    T CreateDarkTheme();
}