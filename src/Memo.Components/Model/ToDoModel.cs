namespace Memo.Components;

public class ToDoModel
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 备注数据
    /// </summary>
    public List<ToDoValueModel> Values { get; set; } = new ();

    /// <summary>
    /// 是否重要
    /// </summary>
    public bool Importance { get; set; }

    /// <summary>
    /// 提醒时间
    /// </summary>
    public DateTime? ReminderTime { get; set; }
    public Guid GroupId { get; set; }
}
