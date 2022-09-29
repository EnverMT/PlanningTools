namespace Models
{
    public class PROJCOST
    {
        public int cost_item_id { get; set; }
        public int? acct_id { get; set; }
        public int? pobs_id { get; set; }
        public int? cost_type_id { get; set; }
        public int proj_id { get; set; }
        public int task_id { get; set; }
        public string? cost_name { get; set; }
        public string? po_number { get; set; }
        public string? vendor_name { get; set; }
        public decimal? act_cost { get; set; }
        public decimal? cost_per_qty { get; set; }
        public decimal? remain_cost { get; set; }
        public decimal? target_cost { get; set; }
        public string? cost_load_type { get; set; }
        public string? auto_compute_act_flag { get; set; }
        public string? target_qty { get; set; }
        public string? qty_name { get; set; }
        public string? cbs_id { get; set; }
        public string? cost_descr { get; set; }
        public string? contract_manager_import { get; set; }
    }
}

/*
 * 
 * %T	PROJCOST
%F	

cost_item_id	
acct_id	
pobs_id	
cost_type_id	
proj_id	
task_id	
cost_name	
po_number	
vendor_name	
act_cost	
cost_per_qty	
remain_cost	
target_cost	
cost_load_type	
auto_compute_act_flag	
target_qty	
qty_name	
cbs_id	
cost_descr	
contract_manager_import


%R	89184				17918	11015775	DTS			0,0000	2000,0000	0,0000	0,0000	CL_End	N	0				
%R	89185				17918	11029346	EUT113			189735,0000	189735,0000	0,0000	189735,0000	CL_End	N	1				

*/ 