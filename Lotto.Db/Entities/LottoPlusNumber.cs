namespace Lotto.Db.Entities;

public class LottoPlusNumber
{
    public int Id { get; set; }
    public LottoNumber LotoNumber { get; set; }
    public int LottoNumberId { get; set; }
    public int? Draw { get; set; }
    public int? PlusNumberFirst { get; set; }
    public int? PlusNumberSecond { get; set; }
    public int? PlusNumberThird{ get; set; }
    public int? PlusNumberFourth { get; set; }
    public int? PlusNumberFifth { get; set; }
    public int? PlusNumberSixth { get; set; }
}