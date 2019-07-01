namespace el_chupitos_pattern.order
{
    public interface IOrderState
    {
        void Action(Order context);
    }
}