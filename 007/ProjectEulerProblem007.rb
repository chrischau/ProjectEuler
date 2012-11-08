startTime = Time.now
number = 1000000

result = 0

sift = Array.new(number)
existingPrimeNumbers = Array.new()

def IsPrime(number, existingPrimeNumbers)
  existingPrimeNumbers.each do |primeNumber|
    if (number % primeNumber == 0)
      return false
    end   
  end
  
  return true
end


for counter in 2..number
  if (sift[counter].nil?)
    if (IsPrime(counter, existingPrimeNumbers))
      existingPrimeNumbers.push(counter)
      puts existingPrimeNumbers.length.to_s + " : " + counter.to_s
      if (existingPrimeNumbers.length == 10001)
        puts "1001st prime: " + counter.to_s
        break
      end
      
      for siftIndex in counter..number
        if (sift[siftIndex].nil? and (siftIndex % counter == 0))
          sift[siftIndex] = "Not Prime"                   
        end
      end      
    end
  end
end

puts "Time took: " + (Time.now - startTime).to_s + " seconds"