public interface IAxisInputAction : IInputAction<float>, IInputAction
{
}

public interface IInputAction<T> : IInputAction where T : struct
{
}