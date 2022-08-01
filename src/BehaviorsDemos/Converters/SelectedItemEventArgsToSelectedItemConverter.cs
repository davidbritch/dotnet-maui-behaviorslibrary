using System.Globalization;
using BehaviorsDemos.Models;

namespace BehaviorsDemos.Converters
{
    public class SelectedItemEventArgsToSelectedItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var eventArgs = value as SelectedItemChangedEventArgs;
            var person = eventArgs.SelectedItem as Person;

            if (parameter != null)
            {
                int ageParam = int.Parse(parameter.ToString());
                person = new Person(person.Name, person.Age, ageParam);
            }
            return person;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
