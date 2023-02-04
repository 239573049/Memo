using Memo.Service.Memo;
using Microsoft.AspNetCore.Components;

namespace Memo.Components.Pages;

public partial class Home
{
    [Inject]
    public IFreeSql FreeSql { get; set; }

    public static List<ToDoGroupModel> ToDoGroupModel { get; set; } = new List<ToDoGroupModel>();

    protected override async Task OnInitializedAsync()
    {
        ToDoGroupModel = (await FreeSql.Select<ToDoGroup>().ToListAsync()).Select(x => new ToDoGroupModel()
        {
            Title = x.Title,
            Background = x.Background,
            Icon = x.Icon,
            Id = x.Id
        }).ToList();

        await base.OnInitializedAsync();
    }
}
