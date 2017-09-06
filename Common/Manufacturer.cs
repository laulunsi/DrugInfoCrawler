namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manufacturer")]
    public partial class Manufacturer
    {
        public int ID { get; set; }

        public string ManufacturerName { get; set; }

        public DateTime? LSST { get; set; }

        public string Link { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public string EnterpriseNumber { get; set; }
        /// <summary>
        /// ������ô���
        /// </summary>
        public string SocialCreditCode { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string ClassificationCode { get; set; }
        /// <summary>
        /// ʡ��
        /// </summary>
        public string ProvinceCity { get; set; }
        /// <summary>
        /// ��ҵ����
        /// </summary>
        public string EnterpriseName { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        public string LegalRepresentative { get; set; }
        /// <summary>
        /// ��ҵ������
        /// </summary>
        public string OwnersofEnterprises { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string QualityDirecter { get; set; }
        /// <summary>
        /// ע���ַ
        /// </summary>
        public string RegisteredAddress { get; set; }
        /// <summary>
        /// ������ַ
        /// </summary>
        public string ProductionAddress { get; set; }
        /// <summary>
        /// ������Χ
        /// </summary>
        public string ProductionRange { get; set; }
        /// <summary>
        /// ��֤����
        /// </summary>
        public string LicenceDate { get; set; }
        /// <summary>
        /// ��Ч��
        /// </summary>
        public string DateofExpiry { get; set; }
        /// <summary>
        /// ��֤����
        /// </summary>
        public string LicenceIssuingAuthority { get; set; }
        /// <summary>
        /// ǩ����
        /// </summary>
        public string Signer { get; set; }
        /// <summary>
        /// �ճ���ܻ���
        /// </summary>
        public string RoutineSupervisionOrganization { get; set; }
        /// <summary>
        /// �ճ������
        /// </summary>
        public string DailySupervisor { get; set; }
        /// <summary>
        /// �ٱ��绰
        /// </summary>
        public string ComplainingTelephone { get; set; }
        public string Remark { get; set; }

        public bool Done { get; set; }
    }
}
