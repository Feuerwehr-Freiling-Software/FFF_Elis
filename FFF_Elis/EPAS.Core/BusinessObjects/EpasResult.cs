namespace EPAS.Core.BusinessObjects;

public class EpasResult<T>(string ErrorText, T Result, EpasResultCode ResultCode)
{
    public string ErrorText { get; set; }
    public T Result { get; set; }
    public EpasResultCode ResultCode { get; set; }
}