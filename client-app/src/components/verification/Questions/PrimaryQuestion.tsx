import {
  Accordion,
  AccordionContent,
  AccordionItem,
  AccordionTrigger,
} from "@/components/ui/accordion";
import { Checkbox } from "@/components/ui/checkbox";
import { QuestionOne } from "./QuestionOne/QuestionOne";
import { QuestionThree } from "./QuestionThree/QuestionThree";
import { QuestionFour } from "./QuestionFour/QuestionFour";
import { QuestionFive } from "./QuestionFive/QuestionFive";
import { QuestionTwo } from "./QuestionTwo/QuestionTwo";

type Props = {
  checkedState: boolean[];
  handleCheckChange: (position: number) => void;
};
export const PrimaryQuestion = ({ checkedState, handleCheckChange }: Props) => {
  return (
    <section>
      <Accordion type="single" collapsible className="w-full">
        <AccordionItem value="item-1">
          <AccordionTrigger>
            <section className="flex items-center gap-3">
              <Checkbox
                checked={checkedState[0]}
                onCheckedChange={() => handleCheckChange(0)}
              />
              Type of account and account balance
            </section>
          </AccordionTrigger>
          <AccordionContent>
            <QuestionOne />
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-2">
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              <Checkbox
                checked={checkedState[1]}
                onCheckedChange={() => handleCheckChange(1)}
              />
              Last 5 Transactions in Account
            </section>
          </AccordionTrigger>
          <AccordionContent>
            <QuestionTwo />
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-3">
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              <Checkbox
                checked={checkedState[2]}
                onCheckedChange={() => handleCheckChange(2)}
              />
              Loan Accounts
            </section>
          </AccordionTrigger>
          <AccordionContent>
            <QuestionThree />
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-4">
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              <Checkbox
                checked={checkedState[3]}
                onCheckedChange={() => handleCheckChange(3)}
              />
              Recurring debits or credits
            </section>
          </AccordionTrigger>
          <AccordionContent>
            <QuestionFour />
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-5">
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              <Checkbox
                checked={checkedState[4]}
                onCheckedChange={() => handleCheckChange(4)}
              />
              Last 5 Debit Transactions
            </section>
          </AccordionTrigger>
          <AccordionContent>
            <QuestionFive />
          </AccordionContent>
        </AccordionItem>
      </Accordion>
    </section>
  );
};
