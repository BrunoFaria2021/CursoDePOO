using Bruno.NotificationContext;
using Bruno.SharedContext;

namespace Bruno.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(
            int order,
            string title,
            string description,
            Course course)
            //na aula de excpicions ensina mais osbre como fazer regra de negocios personalizadas
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso inválido"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}