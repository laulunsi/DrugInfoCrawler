namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Production")]
    public partial class Production
    {
        public int ID { get; set; }

        [StringLength(550)]
        public string ProductionName { get; set; }

        public DateTime? LSST { get; set; }

        public int FromPage { get; set; }

        public bool Done { get; set; }


        public int Importeddrug { get; set; }

        /// <summary>
        /// �ɷ�
        /// </summary>
        public string Ingredient { get; set; }
        /// <summary>
        /// ��״
        /// </summary>
        public string Character { get; set; }
        /// <summary>
        /// ��Ӧ֢
        /// </summary>
        public string PrimaryUses { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// �÷�
        /// </summary>
        public string Usage { get; set; }
        /// <summary>
        /// ������Ӧ
        /// </summary>
        public string UntowardEffect { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Tabu { get; set; }
        /// <summary>
        /// ע������
        /// </summary>
        public string Matters { get; set; }
        /// <summary>
        /// �и���ҩ
        /// </summary>
        public string PregnantUse { get; set; }

        /// <summary>
        /// ��ͯ��ҩ
        /// </summary>
        public string PediatricDrugs { get; set; }
        /// <summary>
        /// ������ҩ
        /// </summary>
        public string OlderDrugs { get; set; }
        /// <summary>
        /// ҩ���໥����
        /// </summary>
        public string DrugInteractions { get; set; }
        /// <summary>
        /// ҩ�����
        /// </summary>
        public string OverDose { get; set; }
        /// <summary>
        /// ҩ����
        /// </summary>
        public string Toxicology { get; set; }
        /// <summary>
        /// ҩ������ѧ
        /// </summary>
        public string Pharmacokinetics { get; set; }
        /// <summary>
        /// �洢
        /// </summary>
        public string Store { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public string Packaging { get; set; }
        /// <summary>
        /// ��Ч��
        /// </summary>
        public string Indate { get; set; }
        /// <summary>
        /// HTML����
        /// </summary>
        public string htmlContent { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Summary { get; set; }
        public string BasicInfo { get; set; }
        /// <summary>
        /// Ŀ¼
        /// </summary>
        public string Catalog { get; set; }

        public virtual ICollection<DrugItem> DrugItems { get; set; }
    }
}
