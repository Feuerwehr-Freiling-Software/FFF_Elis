namespace EPAS.Core.BusinessObjects;

public class EpasResult<T>(string ErrorText, T Result, EpasResultCode ResultCode)
{
    public string ErrorText { get; set; } = ErrorText;
    public T Result { get; set; } = Result;
    public EpasResultCode ResultCode { get; set; } = ResultCode;
}