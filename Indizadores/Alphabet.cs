using System;
using System.Collections.Generic;

namespace Indizadores
{
	public class Alphabet
	{

		public static Alphabet Cryllic = new Alphabet(
			'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'І', 'Й',
			'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ў',
			'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Ы', 'Ь', 'Э', 'Ю', 'Я');

		public static Alphabet Greek = new Alphabet(
			'Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ',
			'Μ', 'Ν', 'Ξ', 'Ο', 'Π', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ',
			'Ψ', 'Ω');
		
		List<char> caracteres;
		private Alphabet(params char[] caracteres)
		{
			this.caracteres = new List<char>(caracteres);
		}

		public char CharacterAt(int i)
		{
			return caracteres[i];
		}

		public char this[int i]
		{
			get { return caracteres[i]; }
		}


	}
}
