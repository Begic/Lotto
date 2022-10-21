namespace Lotto.Db.Entities;

public class LottoNumber
{
    public int Id { get; set; }
    public Lotto Lotto { get; set; }
    public int LottoId { get; set; }
    public int? TippNumber { get; set; }
    public int? FirstNumber { get; set; }
    public int? SecondNumber { get; set; }
    public int? ThirdNumber { get; set; }
    public int? FourthNumber { get; set; }
    public int? FifthNumber { get; set; }
    public int? SixthNumber { get; set; }
    public List<LottoPlusNumber>? LottoPlusNumbers { get; set; }
    public List<LottoJokerNumber>? LottoJokerNumbers { get; set; } 
}