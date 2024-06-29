# YuSi - by Manuel Morales

YuSi is a programming language designed to be interpreted by an interpreter
written in C#. It is a domain-specific language (DSL) created to be expressive
and accessible to Quechua speakers. Here is a more complete definition:

Definition of YuSi YuSi (Yuyay Simikuna) is an interpreted programming language
designed specifically for Quechua speakers. YuSi seeks to provide an intuitive
and accessible syntax through the use of reserved words and control structures
in Quechua, which facilitates the learning and use of the language by native
speakers. The language is interpreted by an interpreter written in C#, which is
responsible for translating and executing programs written in YuSi.

Key features of YuSi:

- Variable Declaration: It allows declaring integer variables using the HUAMPI
  reserved word.
- Value Assignment: Uses the reserved word KANCHAY to assign values to
  variables.
- Arithmetic Operations: Supports basic operations such as addition (LLANPAY),
  subtraction (AQHAY), multiplication (CHINKAY), division (CHUTIY) and remainder
  (QUISPI).
- Comparison operators: Less than (<): WANKA, Greater than (>): HINA, Greater
  than or equal to (>=): HINACHO, Less than or equal to (<=): WANKACHO, Equal to
  (==): KAYCHU, and Different from (!=): MANAN
- Control Structures: Implements conditionals (CHAY for if, CHAYPI for else) and
  loops (QUIPA for while).
- Code Blocks: Use MUYU: to start a code block and PUNCHAW. to end it.

## Demo

```text
YuSi>> HUAMPI x.
chasca
YuSi>> x KANCHAY 0.
0
YuSi>> x.
0
YuSi>> x KANCHAY 5.
5
YuSi>> y.
mana kanchu
YuSi>> y KANCHAY 2.
mana kanchu
YuSi>> HUAMPI y.
chasca
YuSi>> y KANCHAY 10.
10
YuSi>> x LLANPAY 7.
12
YuSi>> x.
5
YuSi>> x KANCHAY x LLANPAY y.
15
YuSi>> x.
15
YuSi>> CHAY (x HINA y)
>> MUYU:
>> x KANCHAY 5.
>> PUNCHAW.
5
YuSi>> x.
5
YuSi>> CHAY ( x HINA y )
>> MUYU:
>> y KANCHAY y AQHAY x.
>> PUNCHAW.
YuSi>> CHAYPI
>> MUYU:
>> x KANCHAY x LLANPAY y.
>> PUNCHAW.
15
YuSi>> x.
15
YuSi>> QUIPA ( x HINA 0 ) MUYU: x KANCHAY x AQHAY 1. PUNCHAW.
14
13
12
11
10
9
8
7
6
5
4
3
2
1
0
YuSi>> x.
0
YuSi>> CHAY (x HINA y) MUYU: x. PUNCHAW. CHAYPI MUYU: y. PUNCHAW.
10
YuSi>>
LLUQSIY...
```

## Installation

```shell
dotnet build
```

## Usage

```shell
dotnet run
```
