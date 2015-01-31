require 'prime'

class PrimeFactors
	def self.generate(number) #static method to generate prime factors
		if number < 2
			return Array.new
		end
			
		pFactors = Array.new
		
		while !Prime.prime?(number) do
			#find smallest prime number that divides temp
      factor = (2..number).each do |n|
        break n if Prime.prime?(n) && number % n ==0
      end
			
			#add factor to list and reassign variables
			pFactors << factor
			number = number / factor
		end
		
		pFactors << number
	end
end

#if this is the main file being executed
if __FILE__ == $0
	puts PrimeFactors.generate(1134)
end