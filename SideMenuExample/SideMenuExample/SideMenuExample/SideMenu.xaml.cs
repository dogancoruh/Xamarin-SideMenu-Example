using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SideMenuExample
{
    public partial class SideMenu : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public SideMenu()
        {
            InitializeComponent();

            var masterPageItems = new List<SideMenuItem>();
            masterPageItems.Add(new SideMenuItem
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(ContactsPage)
            });
            masterPageItems.Add(new SideMenuItem
            {
                Title = "TodoList",
                IconSource = "todo.png",
                TargetType = typeof(TodoListPage)
            });
            masterPageItems.Add(new SideMenuItem
            {
                Title = "Reminders",
                IconSource = "reminders.png",
                TargetType = typeof(ReminderPage)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
