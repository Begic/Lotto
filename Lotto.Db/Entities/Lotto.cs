namespace Lotto.Db.Entities;

public class Lotto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public List<LottoNumber> LottoNumbers { get; set; } = new();
    public int? FirstWinNumber { get; set; }
    public int? SecondWinNumber { get; set; }
    public int? ThirdWinNumber { get; set; }
    public int? FourthWinNumber { get; set; }
    public int? FifthWinNumber { get; set; }
    public int? SixthWinNumber { get; set; }
    public bool? HasWon { get; set; }
    public DateTime? DateOfWinning { get; set; }
    public decimal? PaidSum { get; set; }
    public decimal? WonSum { get; set; }
}