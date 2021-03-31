# Homework2
## �������� ��������� �������.
_______________________________________________________________________________________________________________________________
### ������� �1: 
#### Feature: ����� ���������� ���������� ��������� �������

Scenario: ����� ����� ���������� ��������

Given: ��������� ������ ������ ����� ����� ������

When: ������� ������ "�����������" � "�������� �������"

Then: ��������� "���������"

Example:

| ������ | ������ | ���������|
|:----|:--------------------|:--------------------|
| 3   | 2 3 5      			| 3					  |
| 6   | 4 5 5 2 5 4 		| 4	 				  |
| 10  | 2 3 5 4 7 3 4 3 2 5 | 2 3 5 4 7 3 4 3 2 5 |
_______________________________________________________________________________________________________________________________
### ������� �1(2�������):
#### Feature: ����� ���������� ���������� ��������� �������
Scenario: ����� ����� ���������� ��������
Given: ��������� ������ ������ �������� ����� ������
When: ������� ������ "�������� �������"
Then: ��������� "���������"
Example:

| ������ | ���������|
|:----------------------|:----|
| 2 3 5 				| 3   |
| a f r s f f			| 4   |
| 1 4 d f f 5 6 a s s a | 8	  |

_______________________________________________________________________________________________________________________________
### ������� �2:
#### Feature: �����������, ����������� �� �������

Scenario: ����� ������ "������� ������������" ��� "������� ��������������"

Given: ��������� ������ ������ ����� ����� ������

When: ������� ������ "�����������" � "�������� �������"

Then: ��������� "���������"

Example:
 
 
| ������ | ������ | ���������|
|:-------|:--------------------|:-----------------------|
| 2      | 1 0 0 1             | ������� ������������   |
| 3      | 1 2 3 4 5 6 7 8 9   | ������� �������������� |
| 3      | 1 3 0 3 2 6 0 6 5   | ������� ������������   |


Scenario: ������ �������

Given: ��������� ������ ������ ����� ����� ������

When: ������� ������ "�����������" � "�������� �������"

Then: ��������� "���������"

Example:

| ������ | ������ | ���������|
|:----|:----------------|:------------------------------------------------------------------------------|
| 2   | d d f t         | System.FormatException: "Input string was not in a correct format."           |
| 3   |                 | System.IndexOutOfRangeException: "Index was outside the bounds of the array." |
| 2   | 3.4 4.6 2.5 7.5 | System.FormatException: "Input string was not in a correct format."           |
