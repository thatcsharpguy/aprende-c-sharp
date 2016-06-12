public class Box<T>
{
	public T Content { get; private set; }

	public Box(T content)
	{
		Content = content;
	}

	public override string ToString()
	{
		return string.Format("[Box: Content={0}]", Content);
	}
}