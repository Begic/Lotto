namespace Lotto.Db.Entities;

public class LottoJokerNumber
{
    public int Id { get; set; }
    public LottoNumber LottoNumber { get; set; }
    public int LottoNumberId { get; set; }
    public int? Draw { get; set; }
    public int? JokerNumber { get; set; }
}