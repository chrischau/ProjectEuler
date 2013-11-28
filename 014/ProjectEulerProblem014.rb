@startTime = Time.now
@winningNumber = 0
@chainCounter = 0

def Collatz(number)
  if (number != 1) 
    number = number.even? ? number / 2 : 3 * number + 1
    #puts number
  end
  
  return number
end

for number in 1..1000000
  @loopCounter = 1
  @testNumber = number
  
  while (@testNumber != 1)
    @loopCounter += 1
    @testNumber = Collatz(@testNumber)
    #puts @loopCounter
  end
    
  @chainCounter = @loopCounter >= @chainCounter ? @loopCounter : @chainCounter
  @winningNumber = @loopCounter >= @chainCounter ? number : @winningNumber

end

puts @winningNumber.to_s + " produces the longest chain of " + @chainCounter.to_s
puts "Time took: " + (Time.now - @startTime).to_s + " seconds"