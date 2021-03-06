using System;
using System.Collections.Generic;

namespace Kurs.Api.Server.Dto
{
    public class Substitution
    {
        /// <summary>
        /// ������������� ����������� 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// �������� �����������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ������� ����, ��� ����������� ������ ������������� ������ ������� ��������� � ��������, ��� ����
        /// ���������� ������ ������ ����� ������� � �������� ����������, � ������� ��������� ��������� ����������� �������.
        /// � ����� ������������ �������� ���������� �� ����� ���� �������.
        /// </summary>
        public bool AutoMapping { get; set; }

        /// <summary>
        /// ����� ������� ���������� ����������� 
        /// </summary>
        public IEnumerable<SubstitutionInputArgument> InputArguments { get; set; }

        /// <summary>
        /// ����� �������� ���������� �����������
        /// </summary>
        public IEnumerable<SubstitutionOutputArgument> OutputArguments { get; set; }

        /// <summary>
        /// ����� �������� ������� � ��������������� �� ����� �������� �������� ����������
        /// </summary>
        public IEnumerable<SubstitutionArgumentValuesSet> ArgumentValues { get; set; }
    }
}