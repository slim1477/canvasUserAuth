import {
  Accordion,
  AccordionContent,
  AccordionItem,
  AccordionTrigger,
} from "@/components/ui/accordion";
import { Checkbox } from "@/components/ui/checkbox";

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
              Primary Question 1
            </section>
          </AccordionTrigger>
          <AccordionContent>
            Type of account and account balance
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
              Primary Question 2{" "}
            </section>
          </AccordionTrigger>
          <AccordionContent>Last 5 Transactions in Account</AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-3">
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              <Checkbox
                checked={checkedState[2]}
                onCheckedChange={() => handleCheckChange(2)}
              />
              Primary Question 3{" "}
            </section>
          </AccordionTrigger>
          <AccordionContent>
            Loan Accounts? Payment amount and frequency
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
              Primary Question 4{" "}
            </section>
          </AccordionTrigger>
          <AccordionContent>
            Recurring debits or credits e.g payroll, bill payment, CRA e.t.c
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
              Primary Question 5{" "}
            </section>
          </AccordionTrigger>
          <AccordionContent>Last 5 Debit Card Transactions</AccordionContent>
        </AccordionItem>
      </Accordion>
    </section>
  );
};