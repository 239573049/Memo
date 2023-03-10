namespace Memo.Components;

public class ToDoGroupModel
{
    public Guid Id { get; set; }

    /// <summary>
    /// 列表图标
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// 列表名称
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// 背景
    /// </summary>
    public string Background { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public int Count { get; set; }
}
