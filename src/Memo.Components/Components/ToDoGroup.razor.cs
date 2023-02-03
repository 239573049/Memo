using Memo.Components.Model;
using Microsoft.AspNetCore.Components;

namespace Memo.Components.Components;

public partial class ToDoGroup
{
    [CascadingParameter(Name = nameof(ToDoGroupModel))]
    public List<ToDoGroupModel> ToDoGroupModel { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    private void GoAssignment(ToDoGroupModel model)
    {
        NavigationManager.NavigateTo("/assignment");
    }
}
