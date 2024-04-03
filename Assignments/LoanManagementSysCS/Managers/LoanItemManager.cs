namespace LoanManagementSys.Managers
{
    public class LoanItemManager : GenericManager<LoanItem>
    {
        public List<LoanItem> LoanedItemList { get; set; } = new();

        public bool NoItemsLoaned()
        {
            return (LoanedItemList == null) || (LoanedItemList.Count <= 0);
        }

        public LoanItem CreateLoanItem(Product product, Member member)
        {
            LoanItem loanItem = new LoanItem(product, member);
            Add(loanItem, LoanedItemList);
            return loanItem;
        }
    }
}